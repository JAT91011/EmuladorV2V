using System;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms;

namespace SimuladorV2V.Utilidades
{
    public static class Camara
    {
        public static List<Point> BuscarRectangulo(Image<Bgr, Byte> imgOriginal)
        {
            try
            {
                Point[] puntos = new Point[4];
                List<Point> listadoVertices = new List<Point>();

                // Se combierte la imagen a escala de grises
                Image<Gray, Byte> imgGris = imgOriginal.Convert<Gray, Byte>();

                // Se buscan los vertices en la imagen
                imgGris = imgGris.Canny(new Gray(180), new Gray(120));

                // Se buscan los contornos
                using (MemStorage storage = new MemStorage())
                {
                    for(Contour<Point> contours = imgGris.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage); contours != null; contours = contours.HNext)
                    {
                        Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

                        // Se procesa si el contorno tiene un area mayor que 12000 y un total de lados igual a 4
                        if (currentContour.Area > 12000 && currentContour.Total == 4)
                        {
                            bool esRectangulo = true;
                            puntos = currentContour.ToArray();
                            LineSegment2D[] vertices = PointCollection.PolyLine(puntos, true);
                            for (int i = 0; i < vertices.Length; i++)
                            {
                                // Se comprueba que el angulo entre los vertices sea entre 85 y 95 grados
                                double angulo = Math.Abs(vertices[(i + 1) % vertices.Length].GetExteriorAngleDegree(vertices[i]));
                                if (angulo < 85 || angulo > 95)
                                {
                                    esRectangulo = false;
                                    break;
                                }
                            }
                            if (esRectangulo)
                            {
                                for (int i = 0; i < puntos.Length; i++)
                                {
                                    listadoVertices.Add(puntos[i]);
                                }
                                return listadoVertices;
                            }
                        }
                    }          
                }
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }

        public static List<Point> ReordenarPuntos(List<Point> puntosOriginales)
        {
            try
            {
                List<Point> listadoOrdenados = new List<Point>();
                listadoOrdenados.Add(new Point());
                listadoOrdenados.Add(new Point());
                listadoOrdenados.Add(new Point());
                listadoOrdenados.Add(new Point());

                Point puntoAuxiliar1 = new Point(640, 480);
                Point puntoAuxiliar2 = new Point(640, 480);
                foreach (Point point in puntosOriginales)
                {
                    if (point.X < puntoAuxiliar2.X)
                    {
                        if (point.X < puntoAuxiliar1.X)
                        {
                            puntoAuxiliar2 = puntoAuxiliar1;
                            puntoAuxiliar1 = point;
                        }
                        else
                        {
                            puntoAuxiliar2 = point;
                        }
                    }
                }

                if (puntoAuxiliar1.Y < puntoAuxiliar2.Y)
                {
                    listadoOrdenados[0] = puntoAuxiliar1;
                    listadoOrdenados[3] = puntoAuxiliar2;
                }
                else
                {
                    listadoOrdenados[0] = puntoAuxiliar2;
                    listadoOrdenados[3] = puntoAuxiliar1;
                }

                puntosOriginales.Remove(puntoAuxiliar1);
                puntosOriginales.Remove(puntoAuxiliar2);

                if (puntosOriginales[0].Y < puntosOriginales[1].Y)
                {
                    listadoOrdenados[1] = puntosOriginales[0];
                    listadoOrdenados[2] = puntosOriginales[1];
                }
                else
                {
                    listadoOrdenados[2] = puntosOriginales[0];
                    listadoOrdenados[1] = puntosOriginales[1];
                }

                return listadoOrdenados;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }

        public static Image<Bgr, Byte> CorregirPerspectiva(Image<Bgr, Byte> imgOriginal, List<Point> listadoPuntos)
        {
            try 
            {
                PointF[] puntosExpandidos = new PointF[4];
                puntosExpandidos[0] = new PointF(0,0);
                puntosExpandidos[1] = new PointF(640,0);
                puntosExpandidos[2] = new PointF(640,480);
                puntosExpandidos[3] = new PointF(0,480);

                PointF[] puntosOriginales = new PointF[4];
                puntosOriginales[0] = new PointF(listadoPuntos[0].X, listadoPuntos[0].Y);
                puntosOriginales[1] = new PointF(listadoPuntos[1].X, listadoPuntos[1].Y);
                puntosOriginales[2] = new PointF(listadoPuntos[2].X, listadoPuntos[2].Y);
                puntosOriginales[3] = new PointF(listadoPuntos[3].X, listadoPuntos[3].Y);

                HomographyMatrix homography = CameraCalibration.GetPerspectiveTransform(puntosOriginales, puntosExpandidos);

                return imgOriginal.WarpPerspective(homography, Emgu.CV.CvEnum.INTER.CV_INTER_NN, Emgu.CV.CvEnum.WARP.CV_WARP_FILL_OUTLIERS, new Bgr(0, 0, 0));

            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
    
        public static Image<Bgr, Byte> DibujarRectangulo(Image<Bgr, Byte> imgOriginal, List<Point> listadoPuntos)
        {
            try
            {
                imgOriginal.DrawPolyline(listadoPuntos.ToArray(), true, new Bgr(0, 255, 0), 2);
                return imgOriginal;
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
                return null;
            }
        }

    }
}
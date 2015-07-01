using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;


namespace EmuladorV2I.Utilidades
{
    public static class Camara
    {
        public static List<Point> BuscarCirculos(Image<Bgr, Byte> imgOriginal)
        {
            try
            {
                List<Point> listadoCirculos = new List<Point>();

                // Se combierte la imagen a escala de grises
                Image<Gray, Byte> imgGris = imgOriginal.Convert<Gray, Byte>();

                CvInvoke.cvSmooth(imgGris, imgGris, SMOOTH_TYPE.CV_GAUSSIAN, 3, 3, 0, 0);

                // Se buscan los vertices en la imagen

                // Se buscan los circulos en la imagen
                CircleF[] circulos = imgGris.HoughCircles(
                    new Gray(150),
                    new Gray(75),
                    1.0,        // Resolution of the accumulator used to detect centers of the circles
                    10.0,       // Distancia entre circulos 
                    1,          // Minimo radio
                    100         // Maximo radio
                    )[0];       // Get the circles from the first channel

                // Se obtiene el centro de cada circulo
                foreach (CircleF circulo in circulos)
                {
                    listadoCirculos.Add(new Point((int)circulo.Center.X, (int)circulo.Center.Y));
                }

                return listadoCirculos;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }

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
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
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
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
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
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }
    
        public static Image<Bgr, Byte> DibujarRectangulo(Image<Bgr, Byte> imgOriginal, List<Point> listadoPuntos)
        {
            try
            {
                imgOriginal.DrawPolyline(listadoPuntos.ToArray(), true, new Bgr(0, 255, 0), 3);
                return imgOriginal;
            } catch (Exception exception) {
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }

        public static Image<Bgr, Byte> DibujarCirculo(Image<Bgr, Byte> imgOriginal, Point centro, int diametro, Bgr color)
        {
            try
            {
                imgOriginal.Draw(new CircleF(centro, diametro / 2), color, 3);
                return imgOriginal;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }
        
        public static Image<Bgr, Byte> DibujarRectangulos(Image<Bgr, Byte> imgOriginal, List<Rectangle> listadoRectangulos)
        {
            try
            {
                foreach (Rectangle rectangle in listadoRectangulos)
                {
                    imgOriginal.Draw(rectangle, new Bgr(255, 0, 0), 2);
                }
                return imgOriginal;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }

        public static Image<Bgr, Byte> DibujarCirculos(Image<Bgr, Byte> imgOriginal, List<Point> listadoCentros, int diametro, Bgr color)
        {
            try
            {
                foreach (Point puntos in listadoCentros)
                {
                    imgOriginal.Draw(new CircleF(puntos, diametro / 2), color, 3);
                }
                return imgOriginal;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }

        public static Bgr[] ObtenerColoresMaximoMinimoMedio(Image<Bgr, Byte> imagen, Point punto, int margen)
        {
            try
            {
                Bgr[] colores = new Bgr[3];
                colores[0] = new Bgr(0, 0, 0);
                colores[1] = new Bgr(255, 255, 255);
                colores[2] = new Bgr();

                for (int y = punto.Y - margen; y < punto.Y + margen; y++)
                {
                    for (int x = punto.X - margen; x < punto.X + margen; x++)
                    {
                        // Se comprueba que este dentro de la imagen
                        if (x >= 0 && y >= 0 && x < 640 && y < 480)
                        {
                            // Se obtiene el color del pixel
                            Bgr color = imagen[y, x];

                            // Se comprueba con el maximo y minimo azul
                            if (color.Blue > colores[0].Blue)
                            {
                                colores[0].Blue = color.Blue;
                            }
                            if (color.Blue < colores[1].Blue)
                            {
                                colores[1].Blue = color.Blue;
                            }

                            // Se comprueba con el maximo y minimo verde
                            if (color.Green > colores[0].Green)
                            {
                                colores[0].Green = color.Green;
                            }
                            if (color.Green < colores[1].Green)
                            {
                                colores[1].Green = color.Green;
                            }

                            // Se comprueba con el maximo y minimo rojo
                            if (color.Red > colores[0].Red)
                            {
                                colores[0].Red = color.Red;
                            }
                            if (color.Red < colores[1].Red)
                            {
                                colores[1].Red = color.Red;
                            }
                        }
                    }
                }

                // Se obtiene el color intermedio
                colores[2].Blue = (colores[0].Blue + colores[1].Blue) / 2;
                colores[2].Green = (colores[0].Green + colores[1].Green) / 2;
                colores[2].Red = (colores[0].Red + colores[1].Red) / 2;

                return colores;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Camara", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }

    }
}
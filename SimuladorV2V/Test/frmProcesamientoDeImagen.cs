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
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using EmuladorV2I.Utilidades;

namespace EmuladorV2I.Test
{
    public partial class frmProcesamientoDeImagen : Form
    {

        Capture webCam = null;
        Image<Bgr, Byte> imgOriginal;
        int modo = 0;
        int paso = 0;

        public frmProcesamientoDeImagen()
        {
            InitializeComponent();
        }

        private void frmProcesamientoDeImagen_Load(object sender, EventArgs e)
        {
            webCam = new Capture();
            Application.Idle += ProcesarImagen;
            webCam.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 640);
            webCam.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 480);
        }

        private void frmProcesamientoDeImagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (webCam != null)
                {
                    webCam.Dispose();
                }
                Application.Exit();
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void ProcesarImagen(object sender, EventArgs e)
        {
            try
            {
                imgOriginal = webCam.QueryFrame();
                if (imgOriginal == null)
                {
                    return;
                }

                if(modo == 0)           // Detectar circuito
                {
                    ProcesarDeteccionCircuito();
                } else if(modo == 1)    // Detectar robots
                {
                    ProcesarDeteccionRobots();
                }
                else if (modo == 2)    // Corregir perspectiva
                {
                    ProcesarCorreccionPerspectiva();
                }
                else if (modo == -1)    // Normal
                {
                    ibCamara1.Image = imgOriginal;
                    ibCamara2.Image = imgOriginal;
                }

            }
            catch (Exception exception)
            {
                Excepciones.EscribirError(this.Name, new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        private void ProcesarDeteccionRobots()
        {
            Image<Gray, Byte> imgGris = imgOriginal.Convert<Gray, Byte>();

            if (paso == 0)              // 1.Convertir a escala de grises
            {
                ibCamara1.Image = imgOriginal;
                ibCamara2.Image = imgGris;
            }
            else if (paso == 1)         // 2. Suavizado de imagen     
            {
                ibCamara1.Image = imgGris;
                CvInvoke.cvSmooth(imgGris, imgGris, SMOOTH_TYPE.CV_GAUSSIAN, 3, 3, 0, 0);
                ibCamara2.Image = imgGris;
            }
            else if (paso == 2)         // 2. Se buscan los circulo en la imagen     
            {
                CvInvoke.cvSmooth(imgGris, imgGris, SMOOTH_TYPE.CV_GAUSSIAN, 3, 3, 0, 0);
                ibCamara1.Image = imgGris;
                CircleF[] circulos = imgGris.HoughCircles(
                    new Gray(150),
                    new Gray(75),
                    1.0,        // Resolution of the accumulator used to detect centers of the circles
                    10.0,       // Distancia entre circulos 
                    1,          // Minimo radio
                    100         // Maximo radio
                    )[0];       // Get the circles from the first channel

                // Se dibujan
                foreach (CircleF circulo in circulos)
                {
                      
                }
                ibCamara2.Image = imgOriginal;
            }
        }

        private void ProcesarCorreccionPerspectiva()
        {
            ibCamara1.Image = imgOriginal;

            Point[] puntos = new Point[4];
            List<Point> listadoVertices = new List<Point>();

            // Se combierte la imagen a escala de grises
            Image<Gray, Byte> imgGris = imgOriginal.Convert<Gray, Byte>();

            // Se buscan los vertices en la imagen
            imgGris = imgGris.Canny(new Gray(180), new Gray(120));

            // Se buscan los contornos
            using (MemStorage storage = new MemStorage())
            {
                for (Contour<Point> contours = imgGris.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage); contours != null; contours = contours.HNext)
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
                            break;
                        }
                    }
                }
            }

            ibCamara2.Visible = listadoVertices.Count == 4;

            if (listadoVertices.Count == 4)
            {
                listadoVertices = Camara.ReordenarPuntos(listadoVertices);
                ibCamara2.Image = Camara.CorregirPerspectiva(imgOriginal, listadoVertices);
            }
        }

        private void ProcesarDeteccionCircuito()
        {
            Image<Gray, Byte> imgGris = imgOriginal.Convert<Gray, Byte>();
            
            if (paso == 0)              // 1.Convertir a escala de grises
            {
                ibCamara1.Image = imgOriginal;
                ibCamara2.Image = imgGris;
            }
            else if (paso == 1)         // 2. Se buscan los bordes en la imagen     
            {
                ibCamara1.Image = imgGris;
                imgGris = imgGris.Canny(new Gray(180), new Gray(120));
                ibCamara2.Image = imgGris;
            }
            else if (paso == 2)         // 3. Se buscan los contornos de la imagen
            {
                imgGris = imgGris.Canny(new Gray(180), new Gray(120));
                ibCamara1.Image = imgGris;
                Image<Gray, Byte> imgGris2 = imgGris.Clone();
                using (MemStorage storage = new MemStorage())
                {
                    for (Contour<Point> contours = imgGris.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST); contours != null; contours = contours.HNext)
                    {
                        Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);
                        imgGris2.Draw(contours, new Gray(255), -1);
                    }
                }
                ibCamara2.Image = imgGris2;
            }
        }

        private void btnDetectarCircuito_Click(object sender, EventArgs e)
        {
            if(this.modo != 0)
            {
                paso = 0;
                this.modo = 0;
            }
            else
            {
                paso ++;
                if (this.paso > 2)
                {
                    this.paso = 0;
                }
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.modo = -1;
        }

        private void btnDetectarRobots_Click(object sender, EventArgs e)
        {
            if (this.modo != 1)
            {
                paso = 0;
                this.modo = 1;
            }
            else
            {
                paso++;
                if (this.paso > 2)
                {
                    this.paso = 0;
                }
            }
        }

        private void btnCorregirPerspectiva_Click(object sender, EventArgs e)
        {
            if (this.modo != 2)
            {
                this.modo = 2;
            }
        }

    }
}

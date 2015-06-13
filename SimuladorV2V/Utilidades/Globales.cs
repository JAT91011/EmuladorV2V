using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace SimuladorV2V.Utilidades
{
    public static class Globales
    {
        // CIRCUITO
        public static Image<Bgr, Byte> imgCircuito = null;
        public static List<Point> ListadoVertices = null;

        // PUNTOS DE REFERENCIA
        public static int Margen = 30;
        public static List<Rectangle> ListadoIntersecciones = new List<Rectangle>();

        // BLUETOOTH
        public static String PuertoSerie = String.Empty;
        public static int VelocidadTransmision = 0;
    }
}

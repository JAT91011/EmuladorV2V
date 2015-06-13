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
        public static List<Point> listadoVertices = null;

        // PUNTOS DE REFERENCIA
        public static List<Point> listadoIntersecciones = new List<Point>();

        // BLUETOOTH
        public static String puertoSerie = String.Empty;
        public static int baudrate = 0;
    }
}

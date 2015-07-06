using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using EmuladorV2I.Clases;

namespace EmuladorV2I.Utilidades
{
    public static class Globales
    {
        // CIRCUITO
        public static Image<Bgr, Byte> ImagenCircuito = null;
        public static List<Point> ListadoVertices = null;

        // BIFURCACIONES
        public static int RadioIntersecciones = 50;
        public static List<CircleF> ListadoIntersecciones = new List<CircleF>();

        // ROBOTS
        public static List<Robot> ListadoRobots = new List<Robot>();

        // BLUETOOTH
        public static String PuertoSerie = String.Empty;
        public static int VelocidadTransmision = 0;
    }
}

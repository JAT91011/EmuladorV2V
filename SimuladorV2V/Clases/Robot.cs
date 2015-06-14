using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using SimuladorV2V.Utilidades;

namespace SimuladorV2V.Clases
{
    class Robot
    {
        public static int MODO_LIBRE = 0;
        public static int MODE_RUTA = 1;
        public static int MODE_AVERIADO = 2;

        private String Descripcion;
        private int Modo;

        private Bgr Color;
        private Bgr ColorMaximo;
        private Bgr ColorMinimo;

        private Rectangle UltimaReferencia;
        private Ruta ruta;

    }
}

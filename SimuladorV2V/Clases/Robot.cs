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
    public class Robot
    {
        public static int MODO_LIBRE = 0;
        public static int MODE_RUTA = 1;
        public static int MODE_AVERIADO = 2;

        private int id;
        private String descripcion;
        private int modo;

        private Bgr color;
        private Bgr colorMaximo;
        private Bgr colorMinimo;
        private int velocidad;

        private Rectangle ultimaReferencia;
        private Ruta ruta;
        private String log;

        public Robot()
        {
            this.id = 0;
            this.descripcion = "";
            this.color = new Bgr(0,0,0);
            this.modo = MODO_LIBRE;
            this.colorMaximo = new Bgr(0, 0, 0);
            this.colorMinimo = new Bgr(0, 0, 0);
            this.ultimaReferencia = new Rectangle();
            this.ruta = null;
            this.log = String.Empty;
        }

        public Robot(int id, String descripcion, Bgr color)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.color = color;
            this.modo = MODO_LIBRE;
            this.colorMaximo = new Bgr(0, 0, 0);
            this.colorMinimo = new Bgr(0, 0, 0);
            this.velocidad = 100;
            this.ultimaReferencia = new Rectangle();
            this.ruta = null;
            this.log = String.Empty;
        }

        #region Metodos Get y Set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Modo
        {
            get { return modo; }
            set { modo = value; }
        }

        public Bgr Color
        {
            get { return color; }
            set { color = value; }
        }

        public Bgr ColorMaximo
        {
            get { return colorMaximo; }
            set { colorMaximo = value; }
        }

        public Bgr ColorMinimo
        {
            get { return colorMinimo; }
            set { colorMinimo = value; }
        }

        public int Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        public Rectangle UltimaReferencia
        {
            get { return ultimaReferencia; }
            set { ultimaReferencia = value; }
        }

        public Ruta Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public String Log
        {
            get { return log; }
            set { log = value; }
        }
        #endregion
    }
}
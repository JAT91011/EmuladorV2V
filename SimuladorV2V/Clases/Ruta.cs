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
    public class Ruta
    {
        public static int IZQUIERDA = 0;
        public static int DERECHA = 1;

        private String descripcion;
        private List<Rectangle> referencias;
        private List<int> direcciones;
        private bool bucle;

        public Ruta(String descripcion)
        {
            this.descripcion = descripcion;
            this.referencias = new List<Rectangle>();
            this.direcciones = new List<int>();
            this.bucle = false;
	    }

        #region Metodos Get y Set
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public List<Rectangle> Referencias
        {
            get { return referencias; }
            set { referencias = value; }
        }

        public List<int> Direcciones
        {
            get { return direcciones; }
            set { direcciones = value; }
        }

        public bool Bucle
        {
            get { return bucle; }
            set { bucle = value; }
        }
        #endregion
        
    }
}
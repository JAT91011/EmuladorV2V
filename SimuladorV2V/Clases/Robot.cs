using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using EmuladorV2I.Utilidades;
using System.ComponentModel;

namespace EmuladorV2I.Clases
{
    public class Robot : INotifyPropertyChanged 
    {
        public static int MODO_LIBRE = 0;
        public static int MODE_AVERIADO = 1;

        private int id;
        private int modo;

        private string temperatura;
        private string bateria;

        private Bgr color;
        private Bgr colorMaximo;
        private Bgr colorMinimo;

        private int velocidad;

        private Rectangle ultimaReferencia;

        public event PropertyChangedEventHandler PropertyChanged;

        public Robot()
        {
            this.id = 0;
            this.color = new Bgr(0,0,0);
            this.modo = 0;

            this.temperatura = "0.0";
            this.bateria = "100 %";

            this.colorMaximo = new Bgr(0, 0, 0);
            this.colorMinimo = new Bgr(0, 0, 0);

            this.velocidad = 100;

            this.ultimaReferencia = new Rectangle();
        }

        public Robot(int id, Bgr colorMaximo, Bgr colorMinimo, Bgr color)
        {
            this.id = id;
            this.color = color;
            this.modo = 0;

            this.temperatura = "0.0";
            this.bateria = "100 %";

            this.colorMaximo = colorMaximo;
            this.colorMinimo = colorMinimo;

            this.velocidad = 100;

            this.ultimaReferencia = new Rectangle();
        }

        #region Metodos Get y Set
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Modo
        {
            get { return modo; }
            set { modo = value; }
        }

        public string Temperatura
        {
            get { return temperatura; }
            set { temperatura = value;
            OnPropertyChanged("Temperatura");
            }
        }

        public string Bateria
        {
            get { return bateria; }
            set { bateria = value;
            OnPropertyChanged("Bateria");
            }
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
        #endregion

        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
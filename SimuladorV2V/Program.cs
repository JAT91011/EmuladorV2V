using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EmuladorV2I.Test;

namespace EmuladorV2I
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmBluetoothTester());
            //Application.Run(new frmProcesamientoDeImagen());
            Application.Run(new frmAsistenteConfiguracion());
            Application.Run(new frmPanelPrincipal());
        } 
    }
}

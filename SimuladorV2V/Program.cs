using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimuladorV2V.Temporal;

namespace SimuladorV2V
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
            Application.Run(new frmBluetoothTester());
            //Application.Run(new frmAsistenteConfiguracion());
            //Application.Run(new frmPanelPrincipal());
        }
    }
}

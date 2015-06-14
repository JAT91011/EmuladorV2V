using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimuladorV2V.Utilidades
{
    class Excepciones
    {
        public static void EscribirError(String formulario, String procedimiento, Exception excepcion)
        {
            try
            {
                 String ruta = Path.Combine(Application.StartupPath, "Documentos\\Errores.txt");
                StreamWriter file = new StreamWriter(ruta, true);
                
                // Se escribe la fecha y la hora
                file.WriteLine("Fecha:\t\t\t" + DateTime.Now.ToString("G"));

                // Se escribe en que formulario ha ocurrido
                file.WriteLine("Formulario:\t\t" + formulario);

                // Se escribe en que procedimiento ha ocurrido
                file.WriteLine("Procedimiento:\t" + procedimiento);

                // Se escribe la descripcion de la excepcion
                file.WriteLine("Excepción:\t\t" + excepcion.Message);

                // Se coloca un salto de linea
                file.WriteLine(Environment.NewLine);

                // Se cierra el fichero
                file.Close();
              

                MessageBox.Show(excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

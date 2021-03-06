﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Emgu.CV.Structure;

namespace EmuladorV2I.Utilidades
{
    public static class Utilidades
    {
        public static String LlenarString(String dato, char caracterRelleno, int longitud, String tipoCampo)
        {
            try
            {
                String resultado = "";
                if (dato.Length > longitud)
                {
                    switch (tipoCampo)
                    {
                        case "String":
                            resultado = dato.Substring(0, longitud);
                            break;
                        case "Integer":
                            resultado = dato.Substring(dato.Length - longitud, longitud);
                            break;
                        case "Double":
                            resultado = dato.Substring(dato.Length - longitud, longitud);
                            break;
                    }
                }
                else
                {
                    switch (tipoCampo)
                    {
                        case "String":
                            resultado = dato + new String(caracterRelleno, longitud - dato.Length);
                            break;
                        case "Integer":
                            resultado = new String(caracterRelleno, longitud - dato.Length) + dato;
                            break;
                        case "Double":
                            resultado = new String(caracterRelleno, longitud - dato.Length) + dato;
                            break;
                    }
                }
                return resultado;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Utilidades", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return null;
            }
        }
    
        public static Boolean CirculoContienePunto(CircleF circulo, Point punto)
        {
            try
            {
                //(x - center_x)^2 + (y - center_y)^2 < radius^2
                return  Math.Pow(punto.X - circulo.Center.X, 2) +  Math.Pow(punto.Y - circulo.Center.Y, 2) <  Math.Pow(circulo.Radius, 2);
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Utilidades", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return true;
            }
        }
    }
}

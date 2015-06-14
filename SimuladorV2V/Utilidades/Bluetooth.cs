﻿using System;
using System.IO;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SimuladorV2V.Interfaces;

namespace SimuladorV2V.Utilidades
{
    public class Bluetooth
    {
        private static Bluetooth instancia;
        private SerialPort puertoSerie;
        private List<BluetoothObservador> observadores;

        private Bluetooth()
        {
            puertoSerie = new SerialPort();
            observadores = new List<BluetoothObservador>();
        }

        public bool Conectar(String puerto, int velocidad)
        {
            try
            {
                // Si el puerto está abierto, se cierra para resetearlo
                if (instancia.puertoSerie.IsOpen)
                {
                    instancia.puertoSerie.Close();
                }

                // Se asigna el nombre del puerto
                instancia.puertoSerie.PortName = puerto;

                // Se configura el puerto a la velocidad adecuada
                instancia.puertoSerie.BaudRate = velocidad;

                // Se configura el puerto sin paridad
                instancia.puertoSerie.Parity = Parity.None;

                // Se configura la longitud estándar de los bits de datos por bytes
                instancia.puertoSerie.DataBits = 8;

                // Se configura el tiempo de espera si una operacion de lectura no finaliza
                instancia.puertoSerie.ReadTimeout = 2000;

                // Se configura el tiempo de espera si una operación de escritura no finaliza
                instancia.puertoSerie.WriteTimeout = 2000;

                // Se abre el puerto serie
                instancia.puertoSerie.Open();

                // Se establece el método que actuará cuando ser reciban datos 
                instancia.puertoSerie.DataReceived += new SerialDataReceivedEventHandler(ProcesarDatos);

                // Se devuelve si se ha abierto
                return instancia.puertoSerie.IsOpen;
            } 
            catch (Exception exception) 
            {
                Excepciones.EscribirError("Bluetooth", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return false;
            }
        }

        public bool Enviar(String mensaje)
        {
            try
            {
                instancia.puertoSerie.Write(mensaje);
                return true;
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Bluetooth", new StackTrace().GetFrame(0).GetMethod().Name, exception);
                return false;
            }
        }

        private void ProcesarDatos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[puertoSerie.BytesToRead];
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Bluetooth", new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        #region Observadores
        public void NuevoObservador(BluetoothObservador observador)
        {
            try
            {
                instancia.observadores.Add(observador);
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Bluetooth", new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }

        public void EliminarObservador(BluetoothObservador observador)
        {
            try
            {
                instancia.observadores.Remove(observador);
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Bluetooth", new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        
        public void EliminarTodosObservadores()
        {
            try
            {
                instancia.observadores.Clear();
            }
            catch (Exception exception)
            {
                Excepciones.EscribirError("Bluetooth", new StackTrace().GetFrame(0).GetMethod().Name, exception);
            }
        }
        #endregion

        public static Bluetooth Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Bluetooth();
                }
                return instancia;
            }
        }

    }
}
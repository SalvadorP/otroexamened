using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenED
{
    public class RMB2324_Transporte
    {
        //!? RMB2324 Encapsular campos
        //!? Se hacen los campos privados y
        //!? se crean las propiedades
        private string conductor;
        private int paquete;
        private double pesoCarga;
        private int ruta;

        //!? RMB2324 Reemplazar n�mero m�gico por constante simb�lica.
        public const string ERROR_PAQUETES = "N�mero de paquetes no v�lido.";
        public const string ERROR_RUTA = "N�mero de ruta no v�lido.";
        public const string ERROR_PESO_CARGA = "Peso de carga no v�lido.";
        public const string ERROR_NOMBRE_VACIO = "El nombre no puede ser vac�o.";

        public string Conductor
        {
            get => conductor;
            set
            {
                if (value != "")
                {
                    this.conductor = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(ERROR_NOMBRE_VACIO);
                }
            }
        }

        public int Paquete
        { 
            get => paquete;
            set
            {
                if (value >= 1)
                {
                    this.paquete = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(ERROR_PAQUETES);
                }
            }
        }
        public double PesoCarga
        { 
            get => pesoCarga;
            set
            {
                if (value >= 1)
                {
                    this.pesoCarga = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(ERROR_PESO_CARGA);
                }
            }
        }
        public int Ruta
        { 
            get => ruta;
            set
            {
                if (value >= 1)
                {
                    this.ruta = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(ERROR_RUTA);
                }
            }
        }

        /// <summary>
        /// <para>Constructor por defecto de la clase.</para>
        /// <para>Se inicializan la variable tipo string a vac�o y
        /// las de tipo int y double a 1.</para>
        /// </summary>
        public RMB2324_Transporte()
        {
            try
            {
                //!? RMB2324 Es necesario cambiar las llamadas
                //!? al m�todo set (this.Conductor) por el
                //!? campo (this.campo), para que se asigne el valor a este.
                this.conductor = "";
                this.paquete = 1;
                this.pesoCarga = 1;
                this.ruta = 1;
            }
            catch (ArgumentOutOfRangeException error)
            {
                throw new ArgumentOutOfRangeException(error.Message);
            }
            

        }

        /// <summary>
        /// Constructor parametrizado de la clase.
        /// </summary>
        /// <remarks>Recibe 4 par�metros.</remarks>
        /// <param name="conductor">Valor de tipo string que representa a un conductor.</param>
        /// <param name="paquete">Valor de tipo int que representa el n�mero de paquetes. </param>
        /// <param name="pesoCarga">Valor de tipo double que representa un peso.</param>
        /// <param name="ruta">Valor de tipo int que representa el n�mero ruta.</param>
        public RMB2324_Transporte(string conductor, int paquete, double pesoCarga, int ruta)
        {
            try
            {
                this.Conductor = conductor;
                this.Paquete = paquete;
                this.PesoCarga = pesoCarga;
                this.Ruta = ruta;
            }
            catch (ArgumentOutOfRangeException error)
            {
                throw new ArgumentOutOfRangeException(error.Message);
            }
        }

        /// <summary>
        /// Calcula las paradas a realizar en una ruta.
        /// </summary>
        /// <remarks>No recibe par�metros, usa los propios de la clase.</remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">N�mero de paquetes no v�lido.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">N�mero de ruta no v�lido.</exception>
        /// <returns>N�mero de paradas a realizar.</returns>
        public int CalcularParadas()
        {
            if (this.Paquete < 1)
            {
                //!? RMB2324 Se sustituyen los c�digos de error por excepciones.
                throw new ArgumentOutOfRangeException (ERROR_PAQUETES);
            }
            if (this.Ruta < 1)
            {
                throw new ArgumentOutOfRangeException(ERROR_RUTA);
            }
            int paradas = this.Paquete;
            // Si es random se puede hacer un assert.isTRue(calculado < esperado)
            // siendo esperado = this.paquets => Assert.IsTrue(calculado < this. paquetes, "message");
            // Assert.IsTrue(calculado < this. paquetes, "message");
            // Random random = new Random();
            // paradas = random.Next(1, this.paquetes + 1);
            return paradas;
        }

        /// <summary>
        /// Calcula el n�mero de kil�metros por ruta.
        /// </summary>
        /// <remarks>No recibe par�metros, usa los propios de la clase.</remarks>
        /// <returns> -1 si no hay paquetes.</returns>
        /// <returns> -1 si no hay peso de carga.</returns>
        /// <returns> -1 si no hay n�mero de ruta.</returns>
        /// <returns>N�mero de kil�metros por ruta.</returns>
        public double CalcularKilometrosPorRuta()
        {
            if (this.Paquete < 1)
            {
                throw new ArgumentOutOfRangeException(ERROR_PAQUETES);
            }
            if (this.PesoCarga < 1)
            {
                throw new ArgumentOutOfRangeException(ERROR_PESO_CARGA);
            }
            if (this.Ruta < 1)
            {
                throw new ArgumentOutOfRangeException(ERROR_RUTA);
            }
            double kilometros = (this.PesoCarga * (double)this.Paquete) / 100;
            return kilometros;
        }

        /// <summary>
        /// Calcula el peso de un paquete.
        /// </summary>
        /// <returns> -1 si no hay paquetes.</returns>
        /// <returns> -1 si no hat peso de carga.</returns>
        /// <returns> Peso de cada paquete.</returns>
        public double CalcularPesoPorPaquete()
        {
            if (this.Paquete < 1)
            {
                throw new ArgumentOutOfRangeException(ERROR_PAQUETES);
            }
            if (this.PesoCarga < 1)
            {
                throw new ArgumentOutOfRangeException(ERROR_PESO_CARGA);
            }
            double peso_por_paquete = 0.0;
            peso_por_paquete = this.PesoCarga / (double)this.Paquete;
            return peso_por_paquete;
        }

        /// <summary>
        /// M�todo ToString() en el que se concatena toda la informaci�n.
        /// </summary>
        /// <returns>Un texto con la informaci�n de cada conductor.</returns>
        public string toString()
        {
            return this.Conductor + "\n" +
            this.Paquete + " paquetes\n" +
            this.PesoCarga + " kgs de carga\n" +
            this.Ruta + " ruta\n" +
            "Total Paradas = " + this.CalcularParadas() + "\n" +
            "Peso por paquete = " + this.CalcularPesoPorPaquete() + "\n" +
            "Total Kms = " + this.CalcularKilometrosPorRuta() + "\n";
        }
    }
}

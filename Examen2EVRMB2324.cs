using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenED
{
    internal class Examen2EVRMB2324
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica Examen ED TRANSPORTES\n");

            try
            {
                Console.WriteLine("Transporte 1:");
                RMB2324_Transporte transporte1 = new RMB2324_Transporte();
                transporte1.Conductor = "Dejah Thoris";
                transporte1.Paquete = 15;
                transporte1.PesoCarga = 150;
                transporte1.Ruta = 2;
                Console.WriteLine(transporte1.toString());
            }
            catch (ArgumentOutOfRangeException error)
            {
                if (error.Message.Contains(RMB2324_Transporte.ERROR_RUTA)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_NOMBRE_VACIO)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PAQUETES)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PESO_CARGA))
                {
                    Console.WriteLine("Se ha introducido algún dato erróneo.\n");
                }
            }

            try
            {
                Console.WriteLine("Transporte 2:");
                RMB2324_Transporte transporte2 = new RMB2324_Transporte("Normandy II", 25, 250, 1);
                Console.WriteLine(transporte2.toString());
            }
            catch (ArgumentOutOfRangeException error)
            {
                if (error.Message.Contains(RMB2324_Transporte.ERROR_RUTA)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_NOMBRE_VACIO)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PAQUETES)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PESO_CARGA))
                {
                    Console.WriteLine("Se ha introducido algún dato erróneo.\n");
                }
            }

            try
            {
                Console.WriteLine("Transporte 3:");
                RMB2324_Transporte transporte3 = new RMB2324_Transporte("Nebuchadnezzar", 0, 250, 1);
                Console.WriteLine(transporte3.toString());
            }
            catch (ArgumentOutOfRangeException error)
            {
                if (error.Message.Contains(RMB2324_Transporte.ERROR_RUTA)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_NOMBRE_VACIO)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PAQUETES)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PESO_CARGA))
                {
                    Console.WriteLine("Se ha introducido algún dato erróneo.\n");
                }
            }

            try
            {
                Console.WriteLine("Transporte 4:");
                RMB2324_Transporte transporte4 = new RMB2324_Transporte("X-Wing T-65B", 50, -30, 1);
                Console.WriteLine(transporte4.toString());
            }
            catch (ArgumentOutOfRangeException error)
            {
                if (error.Message.Contains(RMB2324_Transporte.ERROR_RUTA)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_NOMBRE_VACIO)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PAQUETES)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PESO_CARGA))
                {
                    Console.WriteLine("Se ha introducido algún dato erróneo.\n");
                }
            }

            try
            {
                Console.WriteLine("Transporte 5:");
                RMB2324_Transporte transporte5 = new RMB2324_Transporte("Millenium Falcon", 1000, 50, 0);
                Console.WriteLine(transporte5.toString());
            }
            catch (ArgumentOutOfRangeException error)
            {
                if (error.Message.Contains(RMB2324_Transporte.ERROR_RUTA)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_NOMBRE_VACIO)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PAQUETES)
                    || error.Message.Contains(RMB2324_Transporte.ERROR_PESO_CARGA))
                {
                    Console.WriteLine("Se ha introducido algún dato erróneo.\n");
                }
            }

            Console.ReadKey();
        }
    }
}

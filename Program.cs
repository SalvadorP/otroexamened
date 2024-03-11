using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica Examen ED TRANSPORTES");
            Console.WriteLine("Transporte 1:");
            Transporte transporte1 = new Transporte();
            transporte1.cond = "Dejah Thoris";
            transporte1.paq = 15;
            transporte1.pes_carg = 150;
            transporte1.rut = 2;
            Console.WriteLine(transporte1.toString());

            Console.WriteLine("Transporte 2:");
            Transporte transporte2 = new Transporte("Normandy II", 25, 250, 1);
            Console.WriteLine(transporte2.toString());

            Console.WriteLine("Transporte 3:");
            Transporte transporte3 = new Transporte("Nebuchadnezzar", 0, 250, 1);
            Console.WriteLine(transporte3.toString());

            Console.WriteLine("Transporte 4:");
            Transporte transporte4 = new Transporte("X-Wing T-65B", 50, -30, 1);
            Console.WriteLine(transporte4.toString());

            Console.WriteLine("Transporte 5:");
            Transporte transporte5 = new Transporte("Millenium Falcon", 1000, 50, 0);
            Console.WriteLine(transporte5.toString());

        }
    }
}

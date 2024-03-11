using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamenED
{
    public class Transporte
    {
        public string conductor;
        public int paquetes;
        public double peso_carga;
        public int ruta;

        public const int ERROR_PAQUETES = -1;
        public const int ERROR_RUTA = -1;
        public const int ERROR_PESO_CARGA = -1;

        public Transporte() {
            this.conductor = "";
            this.paquetes = 0;
            this.peso_carga = 0.0;
            this.ruta = 0;

        }

        public Transporte(string conductor,int paquetes,double peso_carga,int ruta) {
            this.conductor = conductor;
            this.paquetes = paquetes;
            this.peso_carga = peso_carga;
            this.ruta = ruta;
        }

        public int calculaParadas() {
            if (this.paquetes < 1) {
                return Transporte.ERROR_PAQUETES;
            }
            if (this.ruta < 1) {
                return Transporte.ERROR_RUTA;
            }
            int paradas = this.paquetes;
            // Si es random no hay manera de hacer test unitario y acertar...
            // Random random = new Random();
            // paradas = random.Next(1, this.paquetes + 1);
            return paradas;
        }

        public double kilometrosPorRuta() {
            if (this.paquetes < 1) {
                return Transporte.ERROR_PAQUETES;
            }
            if (this.peso_carga < 1) {
                return Transporte.ERROR_PESO_CARGA;
            }
            double kilometros = (this.peso_carga * (double) this.paquetes) / 100;
            return kilometros;
        }

        public double pesoPorPaquete() {
            if (this.paquetes < 1) {
                return Transporte.ERROR_PAQUETES;
            }
            if (this.peso_carga < 1) {
                return Transporte.ERROR_PESO_CARGA;
            }
            double peso_por_paquete = 0.0;
            peso_por_paquete = this.peso_carga / (double) this.paquetes;
            return peso_por_paquete;
        }

        public string toString() {
            return this.conductor + "\n" +
            this.paquetes + " paquetes\n" +
            this.peso_carga + " kgs de carga\n" +
            this.ruta + " ruta\n" +
            "Total Paradas = " + this.calculaParadas() + "\n" +
            "Peso por paquete = " + this.pesoPorPaquete() + "\n" +
            "Total Kms = " + this.kilometrosPorRuta() + "\n";
        }
    }
}

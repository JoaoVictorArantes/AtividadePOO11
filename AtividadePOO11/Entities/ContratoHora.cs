using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO11.Entities
{
    internal class ContratoHora
    {
        DateTime Data { get; set; }
        double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoHora()
        {
        }
        public ContratoHora(DateTime Data, double ValorPorHora, int Horas)
        {
            this.Data = Data;
            this.ValorPorHora = ValorPorHora;
            this.Horas = Horas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}

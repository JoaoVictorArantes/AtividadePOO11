using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO11.Entities
{
    internal class ContratoHora
    {
        DateTime Date { get; set; }
        double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}

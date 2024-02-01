using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO11.Entities
{
    internal class Trabalhador
    {
        public String Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double BaseSalarial { get; set; }

        public Trabalhador() { }
        public Trabalhador(String Nome, NivelTrabalhador Nivel, double BaseSalarial)
        { 
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.BaseSalarial = BaseSalarial;
        }

        public void AddContrato(ContratoHora contratoHora)
        {
            
        }





    }
}

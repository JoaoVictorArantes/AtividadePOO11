using Microsoft.VisualBasic;
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
        public List<ContratoHora> Contratos { get; private set; } = new List<ContratoHora>();
        public Departamento Departamento { get; set; }

        public Trabalhador() { }
        public Trabalhador(String nome, NivelTrabalhador nivel, double baseSalarial, Departamento departamento)
        { 
            this.Nome = nome;
            this.Nivel = nivel;
            this.BaseSalarial = baseSalarial;
            this.Departamento = departamento;
        }

        public void AddContrato(ContratoHora Contrato)
        {
            Contratos.Add(Contrato);
        }
        public void RemoverContrato(ContratoHora Contrato)
        {
            Contratos.Remove(Contrato);
        }
        public double Renda(int Ano, int Mes)
        {
            double soma = BaseSalarial;

            foreach (ContratoHora contrato in Contratos)
            {
                if (contrato.Data.Year == Ano && contrato.Data.Month == Mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}

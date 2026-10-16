using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaIngressos
{
    public class Ingresso
    {
        protected int id;
        protected string nomeEvento;
        protected double precoBase;

        public Ingresso(int id, string nome, double precoBase)
        {
            this.id = id;
            this.nomeEvento = nome;
            this.precoBase = precoBase;

        }

        public virtual double CalcularValorFinal()
        {
            return this.precoBase;
        }
    }

    public class IngressoVIP : Ingresso
    {
        private double valorCamarote;
        private bool openBar;

        public IngressoVIP(int id, string nome, double precoBase, double valorCamarote, bool openBar) : base(id, nome, precoBase)
        {
            this.valorCamarote = valorCamarote;
            this.openBar = openBar;
        }

        public override double CalcularValorFinal()
        {
            return precoBase + valorCamarote;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

}

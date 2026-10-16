using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    /* ------------------------------------------
                       PROBLEMAS
       ------------------------------------------
        1) USO INDEVDIDO DO PROTECTED
        2) ATRIBUTOS E MÉTODOS DUPLICADOS
        3) FALTA DE HERANÇA 
        4) POSSIBILIDADE DE VALORES INCONSISTENTES
       ------------------------------------------
     */

    public abstract class Conta
    {
        protected string agencia;
        protected string numero;
        protected double saldo;

        public Conta(string agencia, string numero, double saldoInicial)
        {
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = saldoInicial;
        }
        public abstract double CalcularSaldo();

    }

    public class ContaCorrente : Conta
    {
        private double limiteEspecial;

        public ContaCorrente(string agencia, string numero, double saldo, double limiteEspecial) : base( agencia, numero, saldo)
        {
            this.limiteEspecial = limiteEspecial;
        }

        public override double CalcularSaldo()
        {
            return saldo + limiteEspecial;
        }
    }

    public class ContaPoupanca : Conta
    {
        public double taxaRendimento { get; private set; }

        public ContaPoupanca(string agencia, string numero, double taxa, double saldo) : base(agencia, numero, saldo)
        {
            taxaRendimento = taxa;
        }

        public override double CalcularSaldo()
        {
            return saldo + (saldo * taxaRendimento);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

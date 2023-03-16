using System;
using System.Drawing;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco.Contas
{

    public abstract class Conta : Object
    {
        public int Numero { get; set; }

        public double Saldo { get; protected set; }

        public int Tipo { get; set; }
             
        public Cliente Titular { get; set; }
                               
        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

       /* public override string ToString()
        {
            return "titular: " + this.Titular.Nome;
        }*/

        public override bool Equals (object outro)
        {
            if(!(outro is Conta))
            {
                return false;
            }

            Conta outraConta = (Conta) outro;
            return this.Numero == outraConta.Numero;
        }


        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        private static int numeroDeContas;
                           
        public Conta(int numero)
        {
            this.Numero = Numero;
        }

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public virtual void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
            // throw new NotImplementedException();
            if (valorOperacao < 0.0)
            {
                throw new ArgumentException();
            }
           
        }

        public virtual void Transfere(Conta conta, double valor)
        {
            this.Saldo -= valor;
            conta.Saldo += valor;            
        }

                       
        public class TotalizadorDeContas
        {
            public double ValorTotal { get; set; }

            public void Soma(Conta conta)
            {
                ValorTotal += conta.Saldo;
            }

            Conta cc = new ContaCorrente();
            Conta cp = new ContaPoupanca();
            ContaPoupanca c2 = new ContaPoupanca();

            TotalizadorDeContas t = new TotalizadorDeContas();
        }

        
    }
}

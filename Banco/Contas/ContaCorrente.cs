using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.05 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.05;
            }
        }
              
        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
      
        private static int totalDeContas = 0;
        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
        int proxima = ContaCorrente.ProximaConta();



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{

    public class ContaPoupanca : Conta, ITributavel
    {
        public override void Saca(double valor)
        {

            if(valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
             }
            else
            {
                this.Saldo -= valor + 0.10;
            }
                  
        }
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    }

}






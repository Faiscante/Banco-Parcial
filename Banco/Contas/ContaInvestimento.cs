using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaTributos()
        {
            return this.Saldo * 0.03;
        }
    }
}

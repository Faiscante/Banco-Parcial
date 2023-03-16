using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    internal class SeguroDeVida : Conta, ITributavel
    {
        public double CalculaTributos()
        {
            return this.Saldo + 42.0;
        }

    } 
}

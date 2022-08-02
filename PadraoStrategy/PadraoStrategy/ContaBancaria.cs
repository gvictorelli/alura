using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public class ContaBancaria
    {
        public double Valor { get; private set; }

        public ContaBancaria(double valor)
        {
            Valor = valor;
        }
    }
}

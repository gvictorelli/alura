using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public class Investimento
    {
        public double Valor { get; private set; }

        public Investimento(double valor)
        {
            Valor = valor;
        }
    }
}

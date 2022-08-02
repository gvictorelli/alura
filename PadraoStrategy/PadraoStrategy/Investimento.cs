using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public interface Investimento
    {
        public double calculaInvestimento(ContaBancaria contaBancaria);
    }
}

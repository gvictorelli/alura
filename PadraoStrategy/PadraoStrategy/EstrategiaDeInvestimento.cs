using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public interface EstrategiaDeInvestimento
    {
        public long RealizaInvestimento(Investimento investimento);
    }
}

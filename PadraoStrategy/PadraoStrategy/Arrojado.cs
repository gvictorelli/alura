using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoStrategy
{
    public class Arrojado : Investimento
    {
        public double calculaInvestimento(ContaBancaria contaBancaria)
        {
            var roi = contaBancaria.Valor;
            int escolhido = new Random().Next(101);
            if (escolhido <= 20)
                roi = contaBancaria.Valor * 1.05;

            if (escolhido > 20 && escolhido < 50)
                roi = contaBancaria.Valor * 1.03;

            if (escolhido >= 50)
                roi = contaBancaria.Valor * 1.006;

            return roi;
        }
    }
}

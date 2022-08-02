
namespace PadraoStrategy
{
    public class Conservador : Investimento
    {
        public double calculaInvestimento(ContaBancaria contaBancaria)
        {
            //que sempre retorna 0.8 % do valor investido
            return contaBancaria.Valor * 1.008;
        }
    }
}

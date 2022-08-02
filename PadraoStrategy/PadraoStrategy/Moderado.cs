
namespace PadraoStrategy
{
    public class Moderado : Investimento
    {
        public double calculaInvestimento(ContaBancaria contaBancaria)
        {
            double retorno = contaBancaria.Valor * 1.007;
            bool escolhido = new Random().Next(101) > 50;
            if (escolhido)
                retorno = contaBancaria.Valor * 1.025;
                
            return retorno;
        }
    }
}

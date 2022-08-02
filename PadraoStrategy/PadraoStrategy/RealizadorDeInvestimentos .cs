
namespace PadraoStrategy
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(Investimento investimento, ContaBancaria contaBancaria)
        {
            double valor = investimento.calculaInvestimento(contaBancaria);
            Console.WriteLine(valor.ToString());
        }
    }
}

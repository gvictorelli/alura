namespace ChainOfResponsibility.CalculandoDescontos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}

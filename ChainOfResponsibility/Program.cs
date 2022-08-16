using ChainOfResponsibility.CalculandoDescontos;

CalculadorDeDescontos calculador = new CalculadorDeDescontos();

Orcamento orcamento = new Orcamento(500);
orcamento.AdicionaItem(new Item("Caneta", 250));
orcamento.AdicionaItem(new Item("Lapis", 250));
orcamento.AdicionaItem(new Item("Geladeira", 250));
//orcamento.AdicionaItem(new Item("Fogao", 250));
//orcamento.AdicionaItem(new Item("Microondas", 250));
//orcamento.AdicionaItem(new Item("Xbox", 250));

double desconto = calculador.Calcula(orcamento);

Console.WriteLine(desconto);

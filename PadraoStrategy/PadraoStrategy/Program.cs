// See https://aka.ms/new-console-template for more information
using PadraoStrategy;

Console.WriteLine("Hello, World!");

var iss = new ISS();
var icms = new ICMS();

var orcamento = new Orcamento(20.0);

CalculadorDeImposto calculador = new CalculadorDeImposto();
calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, icms);

var contaBancaria = new ContaBancaria(200.0);

var conservador = new Conservador();
var moderado = new Moderado();
var arrojado = new Arrojado();

RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();
realizadorDeInvestimentos.RealizaInvestimento(arrojado, contaBancaria);


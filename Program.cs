// See https://aka.ms/new-console-template for more information
using Interface00.Entities;

Console.WriteLine("Número do contrato: ");
int numeroDoContrato = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Data do contrato: ");
DateTime dataInicial = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Valor total do contrato: ");
double valorTotal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a quantidade de parcelas: ");
int parcelas = Convert.ToInt32(Console.ReadLine());

Contrato contrato = new Contrato()
{
    Numero = numeroDoContrato,
    Data = dataInicial,
    ValorTotal = valorTotal,
};

contrato.CalcularParcelas(parcelas);

Console.WriteLine("Parcelas :");

foreach (var item in contrato.Parcelas)
{
    Console.WriteLine(item.Data.ToShortDateString() + " - " + item.Valor);
}

Console.ReadLine();


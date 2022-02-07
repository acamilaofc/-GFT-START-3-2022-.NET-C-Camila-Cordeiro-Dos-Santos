using CalcularImpostos.Classes;

Console.Write("Digite um valor: ");
double.TryParse(Console.ReadLine(), out double valor);

Impostos impostos = new Impostos(valor);

Console.WriteLine(impostos.ToString());


Console.ReadLine();
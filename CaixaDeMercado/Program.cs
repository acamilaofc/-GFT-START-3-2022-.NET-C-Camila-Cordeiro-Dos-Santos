using CaixaDeMercado.Classes;

Produto banana = new Produto("Banana", 0.99, 2);
Produto energetico = new Produto("Energético", 5.49, 3);
Produto arroz = new Produto("Arroz", 20.0, 1);
Produto chocolate = new Produto("Chocolate", 4.5, 1);
Produto leite = new Produto("Leite", 3.73, 3);
Produto abacaxi = new Produto("Abacaxi", 2.4, 2);

Caixa caixa = new Caixa();

Console.WriteLine("Produto: " + banana.Nome);
Console.WriteLine("Valor Total: R$ " + caixa.CalcularValorFinal(banana, 3).ToString("0.00"));
Console.WriteLine();
Console.WriteLine("Produto: " + energetico.Nome);
Console.WriteLine("Valor Total: R$ " + caixa.CalcularValorFinal(energetico, 7).ToString("0.00"));
Console.WriteLine();
Console.WriteLine("Produto: " + arroz.Nome);
Console.WriteLine("Valor Total: R$ " + caixa.CalcularValorFinal(arroz, 1).ToString("0.00"));
Console.WriteLine();
Console.WriteLine("Produto: " + chocolate.Nome);
Console.WriteLine("Valor Total: R$ " + caixa.CalcularValorFinal(chocolate, 12).ToString("0.00"));
Console.WriteLine();
Console.WriteLine("Produto: " + leite.Nome);
Console.WriteLine("Valor Total: R$ " + caixa.CalcularValorFinal(leite, 5).ToString("0.00"));
Console.WriteLine();
Console.WriteLine("Produto: " + abacaxi.Nome);
Console.WriteLine("Valor Total: R$ " + caixa.CalcularValorFinal(abacaxi, 1).ToString("0.00"));
Console.ReadLine();




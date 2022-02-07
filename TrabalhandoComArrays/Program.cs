using TrabalhandoComArrays.Classes;

Random random = new Random();
Console.WriteLine("Exemplo: ");
int[] novaArray = new int[] { random.Next(1, 100), random.Next(1, 100), random.Next(1, 100), random.Next(1, 100), random.Next(1, 100) };

Console.WriteLine("Números: " + string.Join(", ", novaArray) + Environment.NewLine);

Console.WriteLine(TrabalhandoArrays.ArrayInfo(novaArray));

Console.ReadLine();
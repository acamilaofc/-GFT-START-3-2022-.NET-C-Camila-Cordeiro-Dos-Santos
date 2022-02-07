using ContarLetras.Classes;

Console.Write("Insira a frase: ");
string[] word = Console.ReadLine().Split(' ');

var count = CountLetters.CountingLastWordLetters(word[word.Length - 1]);
Console.WriteLine(count);

Console.ReadLine();

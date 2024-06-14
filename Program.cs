// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] numeros = Enumerable.Range(1, 5).ToArray();

var numerosPares = numeros.Where(n =>
    {
        Console.WriteLine($"Evaluando si {n} es par");
        return n % 2 == 0;
    }).ToList();
//var numerosPares2 = (from n in numeros where n % 2 == 0 select n).ToList();


foreach (var numeros in numerosPares)
{
    Console.WriteLine($"Si el {numeros} es par");
}
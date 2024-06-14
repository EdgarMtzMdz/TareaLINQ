
using System.Windows.Markup;

int[] numeros = Enumerable.Range(0, 20).ToArray();

var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

//Console.WriteLine("Los numeros impares son:");
//foreach (var numero in numerosImpares)
//{
//Console.WriteLine(numero);
// }

var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

var numerosImparesMayoresQue10_2 = from n in numeros
                                   where n % 2 == 1 n > 10
                                        select n;

Console.WriteLine("Los numero impares mayor que 10 son:");
foreach (var numero in numerosImparesMayoresQue10) ;
{
    Console.WriteLine(numero);
}




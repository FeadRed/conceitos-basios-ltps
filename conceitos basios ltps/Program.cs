// See https://aka.ms/new-console-template for more information
/* Exercicios com vetores
 * crie um vetor para armazenar as idades de 6 pessoas e ao final imprima:
 * 1) a pessoa mais nova
 * 2) a pessoa mais velha
 * 3) a media das idades
 * 4) todas as idades impares
 * 5) todas as idades pares
 * 
 */
byte[] idades = new byte[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe a {i+1}ª idade: ");
    idades[i] = byte.Parse(Console.ReadLine());
}
Console.WriteLine("As idades informadas foram :");
foreach(byte idade in idades)
{
    Console.WriteLine(idade);
}

byte media = (byte)((idades[0] + idades[1] + idades[3] + idades[4]) / 5);
Array.Sort(idades);
Console.WriteLine($"A menor idade é:  {idades[0]}");
Console.WriteLine($"A maior idade é: {idades[4]}");
Console.WriteLine($"A média das idades é: {media}");

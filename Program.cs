int numero;

Console.Write("Digite um numero impar ou par: ");
numero = int.Parse(Console.ReadLine()!);
if (numero % 2 == 0)
{
    Console.WriteLine($"O {numero} numero é par");
}
else
{
    Console.WriteLine($"O {numero} numero é impar");
}
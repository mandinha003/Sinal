double numero;

Console.Write("Digite um número: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("POSITIVO");
    Console.ResetColor();
}
else
{
    if (numero < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("NEGATIVO");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("Zero");
    }

}
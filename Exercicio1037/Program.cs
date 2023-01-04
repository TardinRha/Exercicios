// Exercicio 1037
// Fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
// seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra.
// Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

using System.Globalization;
{
    double numeroEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine(" ");
    if (numeroEntrada >= 0 && numeroEntrada <= 25.00)
    {
        Console.WriteLine("Intervalo [0,25]");
    }
    else if (numeroEntrada > 25 && numeroEntrada <= 50)
    {
        Console.WriteLine("Intervalo [25,50]");
    }
    else if (numeroEntrada > 50 && numeroEntrada <= 75)
    {
        Console.WriteLine("Intervalo [50,75]");
    }
    else if (numeroEntrada > 75 && numeroEntrada <= 100)
    {
        Console.WriteLine("Intervalo [75,100]");
    }
    else
    {
        Console.WriteLine("Fora de intervalo");
    }

    Console.ReadLine();
}

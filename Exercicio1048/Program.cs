// Exercicio 1048
// Leia o salário do funcionário e calcule e mostre o novo salário,
// bem como o valor de reajuste ganho e o índice reajustado, em percentual.

using System.Globalization;
{
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine(" ");
    if (salario >= 0 && salario <= 400.00)
    {
        Console.WriteLine("Novo salário: " + (salario + salario * 0.15).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + (salario * 0.15).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: 15%");
    }
    else if (salario >= 400.01 && salario <= 800.00)
    {
        Console.WriteLine("Novo salário: " + (salario + salario * 0.12).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + (salario * 0.12).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: 12%");
    }
    else if (salario >= 800.01 && salario <= 1200.00)
    {
        Console.WriteLine("Novo salário: " + (salario + salario * 0.10).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + (salario * 0.10).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: 10%");
    }
    else if (salario >= 1200.01 && salario <= 2000.00)
    {
        Console.WriteLine("Novo salário: " + (salario + salario * 0.07).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + (salario * 0.07).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: 7%");
    }
    else
    {
        Console.WriteLine("Novo salário: " + (salario + salario * 0.04).ToString("F2"), CultureInfo.InvariantCulture);
        Console.WriteLine("Reajuste ganho: " + (salario * 0.04).ToString("F2"), CultureInfo.InvariantCulture);
        Console.WriteLine("Em percentual: 4%");
    }
    Console.ReadLine();
}
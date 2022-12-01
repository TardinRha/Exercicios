//Exercicio 1008
//Escreva um programa que leia o número de um funcionário,
//seu número de horas trabalhadas,
//o valor que recebe por hora e calcula o salário desse funcionário.
//A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
//O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais,
//representando o número, quantidade de horas trabalhadas e o valor que
//o funcionário recebe por hora trabalhada, respectivamente.

using System.Globalization;
{
    int IdFuncionario = int.Parse(Console.ReadLine());
    int HorasTrabalhadas = int.Parse(Console.ReadLine());
    double ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double Salario = HorasTrabalhadas * ValorHora;

    Console.WriteLine();
    Console.WriteLine("Number = " + IdFuncionario);
    Console.WriteLine("Salary = U$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));
    Console.ReadLine();

}
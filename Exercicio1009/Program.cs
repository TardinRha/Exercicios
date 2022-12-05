using System;
using System.Globalization;

//Exercicio 1009
//Fazer um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro).
//Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas,
//informar o total a receber no final do mês, com duas casas decimais.
//O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais,
//representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.
//Imprimir o total que o funcionário deverá receber.

{
    string NomeVendedor = Console.ReadLine();
    double SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double TotalVendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double SalarioReceber = (TotalVendasEfetuadas * 0.15) + SalarioFixo;

    Console.WriteLine();
    Console.WriteLine("Total = R$ " + SalarioReceber.ToString("F2", CultureInfo.InvariantCulture));
    Console.ReadLine();
}
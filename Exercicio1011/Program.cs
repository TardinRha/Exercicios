using System;
using System.Globalization;

//Exercicio 1011
//Fazer um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio(R).
//A fórmula para calcular o volume é (4/3)*pi*R^3.
//Considerar pi = 3.14159.
//Arquivo de entrada contém um valor de ponto flutuante.
//Saída deverá ser uma mensagem "VOLUME".

{
    double raio = double.Parse(Console.ReadLine());
    double pi = 3.14159;
    double Volume = (4.0 / 3) * pi * (Math.Pow(raio, 3));

    Console.WriteLine();
    Console.WriteLine("Volume = " + Volume.ToString("F3", CultureInfo.InvariantCulture));
    Console.ReadLine();
}

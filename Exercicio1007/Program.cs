//Exercicio 1007
//Leia quatro valores inteiros A, B, C e D.
//A seguir, calcule e mostre a diferença do produto
//de A e B pelo produto de C e D segundo a fórmula:
//DIFERENCA = (A * B - C * D).


using System;
{
    int A = int.Parse(Console.ReadLine());
    int B = int.Parse(Console.ReadLine());
    int C = int.Parse(Console.ReadLine());
    int D = int.Parse(Console.ReadLine());

    int Diferenca = A * B - C * D;

    Console.WriteLine();
    Console.WriteLine("Diferença = " + Diferenca);
    Console.ReadLine();
}

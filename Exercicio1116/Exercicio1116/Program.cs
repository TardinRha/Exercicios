// Exercicio 1116
// Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo.
// Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

using System.Globalization;
{
    int qntPares, x, y;
    double resultado;

    qntPares = int.Parse(Console.ReadLine());


    for (int i = 1; i <= qntPares; i++)
    {
        string[] vet = Console.ReadLine().Split(' ');
        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);

        if (x < 0)
        {
            Console.WriteLine("divisão impossível");
        }
        else
        {
            resultado = (double)x / y;
            Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
        }

    }
    Console.WriteLine();
}
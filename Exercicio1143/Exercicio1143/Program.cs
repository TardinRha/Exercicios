// Exercicio 1143
// Escreva um programa que leia um valor inteiro N (1 < N < 1000).
// Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

{
    int N = int.Parse(Console.ReadLine());

    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{i} ");
        Console.Write($"{i * i} ");
        Console.WriteLine((i * i) * i);
    }
    Console.WriteLine();
}
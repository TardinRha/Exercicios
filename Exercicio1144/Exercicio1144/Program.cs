// Exercicio 1144
// Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa,
// seguindo a lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.


{
    int N = int.Parse(Console.ReadLine());

    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{i} ");
        Console.Write($"{i * i} ");
        Console.WriteLine((i * i) * i);

        Console.Write($"{i} ");
        Console.Write($"{(i * i) + 1} ");
        Console.WriteLine(((i * i) * i) + 1);

    }
    Console.WriteLine();

}
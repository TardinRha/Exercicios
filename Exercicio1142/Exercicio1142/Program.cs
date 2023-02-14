// Exercicio 1142
// Escreva um programa que leia um valor inteiro N.
// Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.


{
    int N = int.Parse(Console.ReadLine());
    int X = 0;

    for (int i = 1; i <= N; i++)
    {
        for (int n = 1; n <= 3; n++)
        {
            Console.Write($"{++X} ");
        }
        Console.WriteLine("PUM");
        X++;
    }
    Console.WriteLine();
}
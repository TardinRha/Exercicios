// Exercicio 1080
// Leia 10 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

{
    int N = 0;
    int maior = 0;
    int linha = 0;

    for (int i = 1; i <= 10; i++)
    {
        N = int.Parse(Console.ReadLine());

        if (N > maior)
        {
            maior = N;
            linha = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine(maior);
    Console.WriteLine(linha);
    Console.WriteLine();
}

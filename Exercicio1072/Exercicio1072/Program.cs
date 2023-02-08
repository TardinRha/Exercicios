// Exercicio 1072
// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.


{
    int X, N;
    int In = 0;
    int Out = 0;

    N = int.Parse(Console.ReadLine());

    for (int i = 1; i <= N; i++)
    {
        X = int.Parse(Console.ReadLine());

        if (X >= 10 && X <= 20)
        {
            In = In + 1;
        }
        if (X < 10 || X > 20)
        {
            Out = Out + 1;
        }
    }

    Console.WriteLine();
    Console.WriteLine(In + " in");
    Console.WriteLine(Out + " out");
    Console.WriteLine();

}
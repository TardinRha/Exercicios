// Exercicio 1074
// Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida.
// Para cada valor lido, mostre uma mensagem em inglês dizendo se este valor lido é
// par (EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE).
// No caso do valor ser igual a zero (0), embora a descrição correta seja (EVEN NULL), pois por definição zero é par,
// seu programa deverá imprimir apenas NULL.

{
    int N = int.Parse(Console.ReadLine());
    int X;

    for (int i = 0; i < N; i++)
    {
        X = int.Parse(Console.ReadLine());

        if (X % 2 == 0)
        {
            if (X == 0)
            {
                Console.Write("NULL");
            }
            else
            {
                Console.Write("EVEN ");
            }
        }
        if (X % 2 != 0)
        {
            Console.Write("ODD ");
        }
        if (X > 0)
        {
            Console.Write("POSITIVE ");
        }
        if (X < 0)
        {
            Console.Write("NEGATIVE ");
        }

        Console.WriteLine();
    }
}

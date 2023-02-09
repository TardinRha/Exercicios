// Exercicio 1132
// Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são múltiplos de 13
// entre X e Y, incluindo ambos.

{
    int resultado = 0;
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());


    if (x < y)
    {
        for (int i = x; i <= y; i++)
        {
            if (i % 13 != 0)
            {
                resultado += i;
            }
        }
    }
    else
    {
        for (int i = y; i <= x; i++)
        {
            if (i % 13 != 0)
            {
                resultado += i;
            }
        }
    }

    Console.WriteLine(resultado);
    Console.WriteLine();
}
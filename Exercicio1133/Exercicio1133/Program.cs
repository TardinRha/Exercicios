// Exercicio 1133
// Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele
// por 5 for igual a 2 ou igual a 3.


{
    int i;

    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (x < y)
    {
        for (i = x++; i < y; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
    else
    {
        for (i = y++; i < x; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }

    Console.WriteLine();
}

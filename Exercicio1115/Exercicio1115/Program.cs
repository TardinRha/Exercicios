// Exercício 1115
// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.
// Para cada ponto escrever o quadrante a que ele pertence.
// O algoritmo será encerrado quando pelo menos uma de duas coordenadas for
// NULA (nesta situação sem escrever mensagem alguma).

{
    int x, y;
    string[] entrada = Console.ReadLine().Split(" ");
    x = int.Parse(entrada[0]);
    y = int.Parse(entrada[1]);

    while (x != 0 && y != 0)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Primeiro Quadrante");
            Console.WriteLine();
        }
        else if (x <= -1 && y > 0)
        {
            Console.WriteLine("Segundo Quadrante");
            Console.WriteLine();
        }
        else if (x <= -1 && y <= -1)
        {
            Console.WriteLine("Terceiro Quadrante");
            Console.WriteLine();
        }
        else if (x > 0 && y <= -1)
        {
            Console.WriteLine("Quarto Quadrante");
            Console.WriteLine();
        }
        entrada = Console.ReadLine().Split(" ");
        x = int.Parse(entrada[0]);
        y = int.Parse(entrada[1]);
    }
}

// Exercício 1113
// Leia uma quantidade indeterminada de duplas de valores inteiros X e Y.
// Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.


{
    int X, Y;
    string[] vet = Console.ReadLine().Split(" ");
    X = int.Parse(vet[0]);
    Y = int.Parse(vet[1]);

    while (X != Y) //Enquanto X for diferente de Y.
    {
        if (X < Y)
        {
            Console.WriteLine("Crescente");
        }
        else
        {
            Console.WriteLine("Decrescente");
        }
        vet = Console.ReadLine().Split(" ");
        X = int.Parse(vet[0]);
        Y = int.Parse(vet[1]);
    }
    Console.ReadLine();
}

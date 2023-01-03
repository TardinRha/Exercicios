
// Exercicio 1044
// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos",
// indicando se os valores lidos são múltiplos entre si.

{
    string[] vet = Console.ReadLine().Split(" ");
    int A = int.Parse(vet[0]);
    int B = int.Parse(vet[1]);

    Console.WriteLine(" ");
    if ((B / A) * A == B)
    {
        Console.WriteLine("São múltiplos");
    }
    else
    {
        Console.WriteLine("Não são múltiplos");
    }
}

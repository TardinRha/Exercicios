// Exercicio 1075
// Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.

{
    int N = int.Parse(Console.ReadLine());
    int resto;

    for (int i = 1; i < 1000; i++)
    {
        resto = i % N;
        if (resto == 2)
        {
            Console.WriteLine(i);
        }
    }
}

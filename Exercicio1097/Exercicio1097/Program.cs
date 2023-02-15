// Exercicio 1097

{
    int x = 1;
    int j = 7;
    int i = 1;
    for (int n = 1; n <= 9; n = n + 2) //enquanto n for menor que 9. n+2
    {
        while (i <= 3) //enquanto i for menor ou igual a 9
        {
            Console.Write($"I={x} "); //escreve o valor de x
            Console.WriteLine($"J={j} "); //escreve o valor de j, que começa com 7.
            --j; //subtrai por 1 o valor de j.
            i++; //soma com 1 o valor de i
        }
        x += 2; //x soma com 2
        j = j + 5; //soma o valor final de j mais 4
        i = 1; //faz i voltar a valer 1
    }
}

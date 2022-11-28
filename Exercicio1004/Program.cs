//Leia dois valores inteiros.
//A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
//A seguir mostre a variável PROD com mensagem correspondente.
//O arquivo de entrada contém 2 valores inteiros.
//Imprimir a mensagem "PROD" e a variável PROD conforme exemplo abaixo,
//com um espaço em branco antes e depois da igualdade.

{
    int A, B, PROD;
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    PROD = A * B;

    Console.WriteLine(" ");
    Console.WriteLine("PROD = " + PROD);

    Console.ReadLine();
}

//Exercicio 1018
//Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual
//o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1.
//A seguir mostre o valor lido e a relação de notas necessárias.
//Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias,
//conforme o exemplo fornecido.

{
    int N = int.Parse(Console.ReadLine());
    int NotasDeCem = N / 100;
    int NotasDeCinquenta = (N % 100) / 50;
    int NotasDeVinte = ((N % 100) % 50) / 20;
    int NotasDeDez = (((N % 100) % 50) % 20) / 10;
    int NotasDeCinco = ((((N % 100) % 50) % 20) % 10) / 5;
    int NotasDeDois = (((((N % 100) % 50) % 20) % 10) % 5) / 2;
    int NotasDeUm = ((((((N % 100) % 50) % 20) % 10) % 5) % 2) / 1;

    Console.WriteLine(" ");
    Console.WriteLine(N);
    Console.WriteLine(NotasDeCem + " nota(s) de R$ 100,00");
    Console.WriteLine(NotasDeCinquenta + " nota(s) de R$ 50,00");
    Console.WriteLine(NotasDeVinte + " nota(s) de R$ 20,00");
    Console.WriteLine(NotasDeDez + " nota(s) de R$ 10,00");
    Console.WriteLine(NotasDeCinco + " nota(s) de R$ 5,00");
    Console.WriteLine(NotasDeDois + " nota(s) de R$ 2,00");
    Console.WriteLine(NotasDeUm + " nota(s) de R$ 1,00");
    Console.ReadLine();
}

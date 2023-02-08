// Exercicio 1079
// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.
// Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
// Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2,
// o segundo valor tem peso 3 e o terceiro valor tem peso 5.

using System.Globalization;
{
    int N;
    double media1, media2, media3;

    N = int.Parse(Console.ReadLine());


    for (int i = 1; i <= N; i++)
    {
        string[] vet = Console.ReadLine().Split(' ');
        double nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture) * 2.0;
        double nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture) * 3.0;
        double nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture) * 5.0;
        media1 = (nota1 + nota2 + nota3) / 10.0;

        Console.WriteLine(media1.ToString("F1", CultureInfo.InvariantCulture));
    }
   
    Console.WriteLine();
}

// Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo.
// O último dado, que não entrará nos cálculos, contém o valor de idade negativa.
// Calcular e imprimir a idade média deste grupo de indivíduos.

using System.Globalization;
{
    double idadeMedia;
    int contagem = 0;
    double somaIdade = 0.0;
    double idade = double.Parse(Console.ReadLine());

    while (idade >= 0)
    {
        somaIdade = somaIdade + idade;
        contagem += 1;
        idade = double.Parse(Console.ReadLine());

    }
    idadeMedia = somaIdade / contagem;

    Console.WriteLine();
    Console.WriteLine("Média = " + idadeMedia.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine();
}

// Exercicio 1118
// Escreva um programa para ler as notas da primeira e a segunda avaliação de um aluno.
// Calcule e imprima a média semestral. O programa só deverá aceitar notas válidas
// (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.
// No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”,
// solicitando ao usuário que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente,
// (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o
// programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.

using System.Globalization;
{
    double notaMedia;
    int novoCalculo = 1;


    while (novoCalculo == 1)
    {
        double PA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (PA < 0 || PA > 10)
        {
            Console.WriteLine("Nota Inválida");
            PA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        double SA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (SA < 0 || SA > 10)
        {
            Console.WriteLine("Nota Inválida");
            SA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        notaMedia = (PA + SA) / 2.0;
        Console.WriteLine("Média = " + notaMedia);
        Console.WriteLine();
        Console.WriteLine("Novo Cálculo (1-Sim  2-Não)");
        novoCalculo = int.Parse(Console.ReadLine());

        while (novoCalculo < 1 || novoCalculo > 2)
        {
            Console.WriteLine("Novo Cálculo (1-Sim  2-Não)");
            novoCalculo = int.Parse(Console.ReadLine());
        }
    }

    Console.WriteLine();

}


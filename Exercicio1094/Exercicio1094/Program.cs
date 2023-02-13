// Exercicio 1094
// Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os
// experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias foram
// utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.
// Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações,
// ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade de
// cobaias utilizadas em cada experimento.


using System.Globalization;
{
    int quantiaTotal = 0;
    int coelhos = 0;
    int ratos = 0;
    int sapos = 0;
    double percentualCoelhos, percentualRatos, percentualSapos;


    int N = int.Parse(Console.ReadLine());

    for (int i = 1; i <= N; i++)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int quantia = int.Parse(vet[0]);
        char tipo = char.Parse(vet[1]);

        quantiaTotal += quantia;

        if (tipo is 'C' or 'c')
        {
            coelhos += quantia;
        }
        if (tipo is 'R' or 'r')
        {
            ratos += quantia;
        }
        if (tipo is 'S' or 's')
        {
            sapos += quantia;
        }
    }
    percentualCoelhos = (double)(100.00 / quantiaTotal) * coelhos;
    percentualRatos = (double)(100.00 / quantiaTotal) * ratos;
    percentualSapos = (double)(100.00 / quantiaTotal) * sapos;


    Console.WriteLine();
    Console.WriteLine("Total: " + quantiaTotal + " cobaias");
    Console.WriteLine("Total de Coelhos: " + coelhos);
    Console.WriteLine("Total de Ratos: " + ratos);
    Console.WriteLine("Total de Sapos: " + sapos);
    Console.WriteLine("Percentual de Coelhos: " + percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture) + "%");
    Console.WriteLine("Percentual de Ratos: " + percentualRatos.ToString("F2", CultureInfo.InvariantCulture) + "%");
    Console.WriteLine("Percentual de Sapos: " + percentualSapos.ToString("F2", CultureInfo.InvariantCulture) + "%");
}

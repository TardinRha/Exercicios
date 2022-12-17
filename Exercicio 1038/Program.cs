//Exercicio 1038
//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

using System.Globalization;
{
    double COD1CachorroQuente = 4.00;
    double COD2XSalada = 4.50;
    double COD3XBacon = 5.00;
    double COD4TorradaSimples = 2.00;
    double COD5Refrigerante = 1.50;

    string[] vet = Console.ReadLine().Split(" ");
    int CODIGO = int.Parse(vet[0]);
    int QUANTIDADE = int.Parse(vet[1]);

    Console.WriteLine(" ");
    switch (CODIGO)
    {
        case 1:
            Console.WriteLine("TOTAL: R$ " + (QUANTIDADE * COD1CachorroQuente).ToString("F2", CultureInfo.InvariantCulture));
            break;
        case 2:
            Console.WriteLine("TOTAL: R$ " + (QUANTIDADE * COD2XSalada).ToString("F2", CultureInfo.InvariantCulture));
            break;
        case 3:
            Console.WriteLine("TOTAL: R$ " + (QUANTIDADE * COD3XBacon).ToString("F2", CultureInfo.InvariantCulture));
            break;
        case 4:
            Console.WriteLine("TOTAL: R$ " + (QUANTIDADE * COD4TorradaSimples).ToString("F2", CultureInfo.InvariantCulture));
            break;
        case 5:
            Console.WriteLine("TOTAL: R$ " + (QUANTIDADE * COD5Refrigerante).ToString("F2", CultureInfo.InvariantCulture));
            break;
        default:
            Console.WriteLine("Código Informado Inválido");
            break;
    }
    Console.ReadLine();

}


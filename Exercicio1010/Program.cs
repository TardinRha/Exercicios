using System.Globalization;

//Ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
//o código de uma peça 2, o número de peças 2, o valor unitário de cada peça 2.
//Calcular e mostrar o valor a ser pago.
//Entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente,
//doi inteiros e um valor com 2 casas decimais.

{
    string[] PedidoUm = Console.ReadLine().Split(' ');
    int PeçaUm = int.Parse(PedidoUm[0]);
    int QuantidadeUm = int.Parse(PedidoUm[1]);
    double ValorUm = double.Parse(PedidoUm[2], CultureInfo.InvariantCulture);

    string[] PedidoDois = Console.ReadLine().Split(' ');
    int PeçaDois = int.Parse(PedidoDois[0]);
    int QuantidadeDois = int.Parse(PedidoDois[1]);
    double ValorDois = double.Parse(PedidoDois[2], CultureInfo.InvariantCulture);

    double ValorParaPagar = QuantidadeUm * ValorUm + QuantidadeDois* ValorDois;

    Console.WriteLine();
    Console.WriteLine("Valor a Pagar: R$ " + ValorParaPagar.ToString("F2", CultureInfo.InvariantCulture));
    Console.ReadLine();
}

using System.Globalization;

// Exercicio 1014
//Calcular o consumo médio de um automóvel sendo fornecidos a distância total percorrida em Km,
//e o total de combustível gasto em Litros.
//Entrada contém dois valores: um inteiro representando a distância total percorrida em Km,
// e um valor real representando o total de combustível gasto, com um dígito após o ponto decimal.

{
    int DistanciaPercorrida = int.Parse(Console.ReadLine());
    double CombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double ConsumoMedio = DistanciaPercorrida / CombustivelGasto;

    Console.WriteLine();
    Console.WriteLine(ConsumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " Km/l");
    Console.ReadLine();
}

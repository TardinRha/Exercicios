//Exercicio 1015
//Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano,
//p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:
//Distancia = raiz quadrada de (X2 - X1)² + (Y2 - Y1)².
//O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1
//e a segunda linha contém dois valores de ponto flutuante x2 y2.
//Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

using System.Globalization;
{
    string[] vet = Console.ReadLine().Split(" ");
    double X1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
    double Y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);
    
    vet = Console.ReadLine().Split(" ");
    double X2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
    double Y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

    double Distancia = (Math.Sqrt(Math.Pow(X2 - X1, 2.0) + Math.Pow(Y2 - Y1, 2.0)));

    Console.WriteLine(" ");
    Console.WriteLine("DISTÂNCIA = " + Distancia.ToString("F4", CultureInfo.InvariantCulture));
    Console.ReadLine();
}
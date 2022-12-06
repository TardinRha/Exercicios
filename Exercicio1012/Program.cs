//Exercício 1012
//Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.
//O arquivo de entrada contém três valores com um dígito após o ponto decimal.
//O arquivo de saída deverá conter 5 linhas de dados.
//Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. 

using System.Globalization;
{
    double pi = 3.14159;
    string[] vet = Console.ReadLine().Split(" ");
    double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
    double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
    double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

    double AreaTriangulo = (A * C) / 2.0;
    double AreaCirculo = pi * (Math.Pow(C, 2));
    double AreaTrapezio = ((A + B) * C) / 2.0;
    double AreaQuadrado = B * B;
    double AreaRetangulo = A * B;

    Console.WriteLine(" ");
    Console.WriteLine("TRIÂNGULO = " + AreaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("CIRCULO = " + AreaCirculo.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("TRAPEZIO = " + AreaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("QUADRADO = " + AreaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
    Console.WriteLine("RETANGULO = " + AreaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
    Console.ReadLine();
}
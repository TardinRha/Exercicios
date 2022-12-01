//Exercicio 1006
//Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno.
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2,
//a nota B tem peso 3 e a nota C tem peso 5.
//Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
//O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
//Imprima a mensagem "MEDIA" e a média do aluno,
//com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade.

using System;
using System.Globalization;
{
double A, B, C, MEDIA;
    A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 2.0;
    B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 3.0;
    C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 5.0;
    MEDIA = ((A + B + C) / 10);

    Console.WriteLine(" ");
    Console.WriteLine("MÉDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));

    Console.ReadLine();

}

//Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
//A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5
//(A soma dos pesos portanto é 11).
//Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
//O arquivo de entrada contém 2 valores com uma casa decimal cada um.
//Imprima a mensagem "MEDIA" e a média do aluno,
//com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade.

using System.Globalization;
{
    double A, B, MEDIA;
    A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 3.5;
    B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 7.5;
    MEDIA = (A + B) / 11;

    Console.WriteLine(" ");
    Console.WriteLine("MÉDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

    Console.ReadLine();
}


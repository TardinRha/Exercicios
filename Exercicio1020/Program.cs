//Exercicio 1020
//Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias.

{
    int IdadeEmDias = int.Parse(Console.ReadLine());
    int IdadeAnos = IdadeEmDias / 365;
    int IdadeMeses = (IdadeEmDias % 365) / 30;
    int IdadeDias = (IdadeEmDias % 365) % 30;

    Console.WriteLine(" ");
    Console.WriteLine(IdadeAnos + " ano (s).");
    Console.WriteLine(IdadeMeses + " mês (es).");
    Console.WriteLine(IdadeDias + " dia (s).");
    Console.ReadLine();
}


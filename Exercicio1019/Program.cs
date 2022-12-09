//Exercicio 1019
//Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
//e informe-o expresso no formato horas:minutos:segundos.
//Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos.
// 1 Hora = 3600 segundos.

{
    int TempoSegundos = int.Parse(Console.ReadLine());
    int Horas = TempoSegundos / 3600;
    int Minutos = (TempoSegundos % 3600) / 60;
    int Segundos = (TempoSegundos % 3600) % 60;

    Console.WriteLine(" ");
    Console.WriteLine(Horas + ":" + Minutos + ":" + Segundos);
    Console.ReadLine();
}


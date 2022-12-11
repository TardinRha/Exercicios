//Exercicio 1061
//Pedrinho está organizando um evento em sua Universidade.
//O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês.
//O problema é que Pedrinho quer calcular o tempo que o evento vai durar,
//uma vez que ele sabe quando inicia e quando termina o evento.
//Sabendo que o evento pode durar de poucos segundos a vários dias,
//você deverá ajudar Pedrinho a calcular a duração deste evento.

{
    string DiaInicio = Console.ReadLine();
    string[] vet = DiaInicio.Split(" ");
    int NumeroDiaInicio = int.Parse(vet[1]);

    vet = Console.ReadLine().Split(":");
    int HoraInicio = int.Parse(vet[0]);
    int MinutosInicio = int.Parse(vet[1]);
    int SegundosInicio = int.Parse(vet[2]);

    string DiaTermino = Console.ReadLine();
    vet = DiaTermino.Split(" ");
    int NumeroDiaTermino = int.Parse(vet[1]);

    vet = Console.ReadLine().Split(":");
    int HoraTermino = int.Parse(vet[0]);
    int MinutosTermino = int.Parse(vet[1]);
    int SegundosTermino = int.Parse(vet[2]);

    int DiasTotais = NumeroDiaTermino - NumeroDiaInicio;
    int HorasTotais = (DiasTotais * 24 + HoraTermino) - HoraInicio;
    DiasTotais = HorasTotais / 24;
    double RestoHorasTotais = HorasTotais % 24;
    double MinutosTotais = MinutosTermino - MinutosInicio;
    int SegundosTotais = SegundosTermino - SegundosInicio;

    Console.WriteLine(" ");
    Console.WriteLine(DiasTotais + " dia (s)");
    Console.WriteLine(RestoHorasTotais + " hora (s)");
    Console.WriteLine(MinutosTotais + " minuto (s)");
    Console.WriteLine(SegundosTotais + " segundo (s)");
    Console.ReadLine();
}


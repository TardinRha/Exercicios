// Exercicio 1050
// Leia um número inteiro que representa um código de DDD para discagem interurbana.
// Em seguida, informe à qual cidade o DDD pertence, considerando a tabela.
// Se a entrada for qualquer outro DDD que não esteja presente na tabela acima,
// o programa deverá informar: DDD nao cadastrado.

{
    string DDD;
    int entrada = int.Parse(Console.ReadLine());

    switch (entrada)
    {
        case 61:
            DDD = "Brasília";
            break;
        case 71:
            DDD = "Salvador";
            break;
        case 11:
            DDD = "São Paulo";
            break;
        case 21:
            DDD = "Rio de Janeiro";
            break;
        case 32:
            DDD = "Juíz de Fora";
            break;
        case 19:
            DDD = "Campinas";
            break;
        case 27:
            DDD = "Vitória";
            break;
        case 31:
            DDD = "Belo Horizonte";
            break;
        default:
            DDD = "DDD não encontrado";
            break;
    }
    Console.WriteLine(" ");
    Console.WriteLine(DDD);
    Console.ReadLine();
}

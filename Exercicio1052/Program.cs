// Exercicio 1052
// Leia um valor inteiro entre 1 e 12, inclusive.
// Correspondente a este valor, deve ser apresentado como resposta o mês do ano por extenso,
// em inglês, com a primeira letra maiúscula.

{
    string month;
    int entrada = int.Parse(Console.ReadLine());

    switch (entrada)
    {
        case 1:
            month = "January";
            break;
        case 2:
            month = "February";
            break;
        case 3:
            month = "March";
            break;
        case 4:
            month = "April";
            break;
        case 5:
            month = "May";
            break;
        case 6:
            month = "June";
            break;
        case 7:
            month = "July";
            break;
        case 8:
            month = "August";
            break;
        case 9:
            month = "September";
            break;
        case 10:
            month = "October";
            break;
        case 11:
            month = "November";
            break;
        case 12:
            month = "December";
            break;
        default:
            month = "Mês inexistente";
            break;
    }
    Console.WriteLine(" ");
    Console.WriteLine(month);
    Console.ReadLine();
}

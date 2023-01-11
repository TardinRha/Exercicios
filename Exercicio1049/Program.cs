//Exercicio 1049
//Ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.
//Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

{
    string tipo = Console.ReadLine();
    string especie = Console.ReadLine();
    string tipoAlimentacao = Console.ReadLine();

    Console.WriteLine(" ");
    if (tipo == "vertebrado" && especie == "ave" && tipoAlimentacao == "carnivoro")
    {
        Console.WriteLine("águia");
    }
    else if (tipo == "vertebrado" && especie == "ave" && tipoAlimentacao == "onivoro")
    {
        Console.WriteLine("pomba");
    }
    else if (tipo == "vertebrado" && especie == "mamifero" && tipoAlimentacao == "onivoro")
    {
        Console.WriteLine("homem");
    }
    else if (tipo == "vertebrado" && especie == "mamifero" && tipoAlimentacao == "herbivoro")
    {
        Console.WriteLine("vaca");
    }
    else if (tipo == "invertebrado" && especie == "inseto" && tipoAlimentacao == "hematofago")
    {
        Console.WriteLine("pulga");
    }
    else if (tipo == "invertebrado" && especie == "inseto" && tipoAlimentacao == "herbivoro")
    {
        Console.WriteLine("lagarta");
    }
    else if (tipo == "invertebrado" && especie == "anelideo" && tipoAlimentacao == "hematofago")
    {
        Console.WriteLine("sanguessuga");
    }
    else if (tipo == "invertebrado" && especie == "anelideo" && tipoAlimentacao == "onivoro")
    {
        Console.WriteLine("minhoca");
    }
    else
    {
        Console.WriteLine("Erro");
    }

    Console.ReadLine();

}

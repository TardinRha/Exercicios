// Exercicio 1134
// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
// Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma:
// 1.Álcool 2.Gasolina 3.Diesel 4.Fim).Caso o usuário informe um código inválido (fora da faixa de 1 a 4)
// deve ser solicitado um novo código (até que seja válido).
// O programa será encerrado quando o código informado for o número 4.

{
    int combustivel = int.Parse(Console.ReadLine());
    int contagemAlcool = 0;
    int contagemGasolina = 0;
    int contagemDiesel = 0;

    while (combustivel != 4)
    {
        switch (combustivel)
        {
            case 1:
                contagemAlcool += 1;
                break;

            case 2:
                contagemGasolina += 1;
                break;

            case 3:
                contagemDiesel += 1;
                break;
        }
        combustivel = int.Parse(Console.ReadLine());
    }

    Console.WriteLine();
    Console.WriteLine("MUITO OBRIGADA!");
    Console.WriteLine("Álcool: " + contagemAlcool);
    Console.WriteLine("Gasolina: " + contagemGasolina);
    Console.WriteLine("Diesel: " + contagemDiesel);
}

﻿// Exercicio 1114 - Com implementações
// Escreva um programa que repita a leitura de uma senha até que ela seja válida.
// Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
// Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
// Considere que a senha correta é o valor 2002. 


{
    int senha;

    do
    {
        senha = int.Parse(Console.ReadLine());
        if (senha != 2002)
        {
            Console.WriteLine("Senha Inválida");
            Console.WriteLine();
        }
    }
    while (senha != 2002);

    Console.WriteLine("Acesso Permitido");
}

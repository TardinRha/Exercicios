﻿//Exercício 1001
//Leia 2 valores inteiros e armazene-os nas variáveis A e B.
//Efetue a soma de A e B atribuindo o seu resultado na variável X.
//Imprima X conforme exemplo apresentado abaixo.
//Não apresente mensagem alguma além daquilo que está sendo especificado
//e não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
//A entrada contém 2 valores inteiros.
//Imprima a mensagem "X = " (letra X maiúscula) seguido pelo valor da variável X e pelo final de linha.

{
    int A, B, X;
    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    X = A + B;

    Console.WriteLine(" ");
    Console.WriteLine("X = " + X);

    Console.ReadLine();
}
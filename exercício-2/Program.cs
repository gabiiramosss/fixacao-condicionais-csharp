﻿//Faça um programa que leia três números e mostre o maior e o menor deles.

int numero1;
int numero2;
int numero3;

int maior;
int menor;

Console.WriteLine($"Digite o primeiro número: ");
numero1 = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite o segundo número: ");
numero2 = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite o terceiro número: ");
numero3 = int.Parse (Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    maior = numero1;
}
else if (numero2 > numero1 && numero2 > numero3)
{
    maior = numero2;
}
else
{
    maior = numero3;
}

if (numero1 < numero2 && numero1 < numero3)
{
    menor = numero1;
}
else if (numero2 < numero1 && numero2 < numero3)
{
    menor = numero2;
}
else
{
    menor = numero3;
}

Console.WriteLine($"O maior número corresponde a {maior} o menor corresponde a {menor}");

// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

int dia;
int mes;
int ano;

Console.WriteLine($"Digite seu dia de nascimento: ");
dia = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite o mês de nascimento: ");
mes = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite o ano de nascimento: ");
ano = int.Parse (Console.ReadLine());

if (dia <= 31 && mes <= 12 && ano <= 2013)
{
    Console.WriteLine($"Válido");
}
else if (dia > 31)
{
    Console.WriteLine($"Inválido. Motivo: dia não corresponde.");
}
else if (mes > 12)
{
    Console.WriteLine($"Inválido. Motivo: mês não corresponde.");
}
else if (ano > 2013)
{
    Console.WriteLine($"Inválido. Motivo: ano não corresponde.");
}
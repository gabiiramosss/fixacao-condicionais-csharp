// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
//"Telefonou para a vítima?"
//"Esteve no local do crime?"
//"Mora perto da vítima?"
//"Devia para a vítima?"
//"Já trabalhou com a vítima?"
//O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente".

Console.WriteLine($"Responda as perguntas com sim ou não");

Console.WriteLine($"Telefonou para a vítima?");
string phone = Console.ReadLine().ToLower();

Console.WriteLine($"Esteve no local do crime?");
string local = Console.ReadLine().ToLower();

Console.WriteLine($"Mora perto da vítima?");
string living = Console.ReadLine().ToLower();

Console.WriteLine($"Devia para a vítima?");
string owned = Console.ReadLine().ToLower();

Console.WriteLine($"Já trabalhou com a vítima?");
string work = Console.ReadLine().ToLower();

int contSim = 0;

if (phone == "sim")
{
    contSim++;
}

if (local == "sim")
{
    contSim++;
}

if (living == "sim")
{
    contSim++;
}

if (owned == "sim")
{
    contSim++;
}

if (work == "sim")
{
    contSim++;
}

if (contSim == 2)
{
    Console.WriteLine($"Suspeito!");
}
else if (contSim > 2 && contSim <= 4)
{
    Console.WriteLine($"Cúmplice...");
}
else if (contSim == 5)
{
    Console.WriteLine($"CULPADO!!!!!");
}
else
{
    Console.WriteLine($"Inocente");
}
//Escreva um programa que pergunte o raio de uma circunferência, e em seguida mostre o diâmetro, comprimento e área da circunferência.

float raio;
float diametro;
float comprimento;
float area;

Console.WriteLine($"Informe o raio da circunferência: ");
raio = float.Parse (Console.ReadLine());

diametro = (2 * raio);
comprimento = (float)(diametro * Math.PI);
area = (float)(Math.PI * Math.Pow(raio,2));

Console.WriteLine($"O diâmetro corresponde a {diametro}, comprimento corresponde a {comprimento} e área corresponde a {area}.");

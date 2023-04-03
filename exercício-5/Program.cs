// Faça um programa que verifique se uma letra digitada é vogal ou consoante

char letra;

Console.WriteLine($"Digite uma letra: ");
letra = char.Parse (Console.ReadLine());

if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
{
    Console.WriteLine($"Vogal");
}
else
{
    Console.WriteLine($"Consoante");
}
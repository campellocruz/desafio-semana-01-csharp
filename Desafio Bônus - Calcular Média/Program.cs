double CalcularMedia(int nota1, int nota2, int nota3)
{

    return (nota1 + nota2 + nota3) / 3;
}
Console.WriteLine($"Nota 1: 8");
Console.WriteLine($"Nota 2: 6");
Console.WriteLine($"Nota 3: 7");

Console.WriteLine($"Média: {CalcularMedia(8, 6, 7)}");
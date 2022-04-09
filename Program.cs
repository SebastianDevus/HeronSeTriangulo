// Exercicio complicado, mas divertido

// As variáveis são usadas para validar e calcular a área do triângulo, por isso os nomes
double a, b, c, s, areaTriangulo;


//Espacamento
Console.WriteLine();


Console.Write("Insira o primeiro lado..: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o segundo lado...: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o terceiro lado..: ");
c = Convert.ToDouble(Console.ReadLine());


//Espacamento
Console.WriteLine();



//Validando os lados
if (
    a < (b + c) && a > Math.Abs(b - c) &&
    b < (a + c) && b > Math.Abs(a - c) &&
    c < (a + b) && c > Math.Abs(a - b) &&
    a > 0 && b > 0 && c > 0)
{ 
    // Será executado se os lados forem válidos

    // Calculando a área
    s = ((a + b + c) / 2 );

    areaTriangulo = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

    // Verificando o tipo de triangulo
    if (a == b && a == c)
    {
        // Triângulo Equilátero
        Console.WriteLine("O triângulo que você informou é um triângulo Equilátero");
    }
    else if (a != b && a != c && b != c)
    {
        // Triângulo Escaleno
        Console.WriteLine("O triângulo que você informou é um Triângulo Escaleno");
    }
    else
    {
        //Triângulo Isósceles
        Console.WriteLine("O triângulo que você informou é um Triângulo Isósceles");
    }

    // Isso aparecerá depois do tipo de triângulo
    Console.WriteLine($"Sua área é {areaTriangulo:N2}");
}
else
{
    // Será executado se os lados forem inválidos
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Beep();

    Console.WriteLine("Esses lados não constituem um triângulo!");
    Console.ResetColor();
}


//Espacamento
Console.WriteLine();
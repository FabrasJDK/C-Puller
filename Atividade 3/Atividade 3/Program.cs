using System.Globalization;

try
{
    Console.Write("Digite seu Primeiro número: ");
    double n1;
    //! é = diferente
    {
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n1))
            Console.WriteLine("Digite um número válido: ");
        Console.Write("Digite o primeiro número");
    }

    {
        Console.Write("\nDigite o seu Segundo número: ");
        double n2;
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n2))
            Console.WriteLine("Digite um número válido: ");
        Console.Write("Digite o segundo número");

      
        double soma = n1 + n2;
        Console.WriteLine($"\nO resultado da soma é: {soma}");
    }
}
catch (DivideByZeroException)

{
    Console.WriteLine("\nErro: Não foi possível somar esses números");
}
//catch (FormatException)
//{
//    Console.WriteLine("\nPorfavor digite números válidos");
//}

Console.ReadKey();
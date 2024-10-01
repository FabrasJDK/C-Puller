Console.WriteLine("\nEscolha um número de 1 a 12 (cada um indica um mês do ano)");

int mes = int.Parse(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine("Você escolheu o mês de Janeiro e é VERÃO !!!");
        break;

    case 2:
        Console.WriteLine("Você escolheu o mês de Fevereiro e é VERÃO !!!");
        break;

    case 3:
        Console.WriteLine("Você escolheu o mês de Março e é OUTONO !!!");
        break;

    case 4:
        Console.WriteLine("Você escolheu o mês de Abril e é OUTONO !!!");
        break;

    case 5:
        Console.WriteLine("Você escolheu o mês de Maio e é OUTONO !!!");
        break;

    case 6:
        Console.WriteLine("Você escolheu o mês de Junho e é INVERNO !!!");
        break;

    case 7:
        Console.WriteLine("Você escolheu o mês de Julho e é INVERNO !!!");
        break;

    case 8:
        Console.WriteLine("Você escolheu o mês de Agosto e é INVERNO !!!");
        break;

    case 9:
        Console.WriteLine("Você escolheu o mês de Setembro e é PRIMAVERA !!!");
        break;

    case 10:
        Console.WriteLine("Você escolheu o mês de Outubro e é PRIMAVERA !!!");
        break;

    case 11:
        Console.WriteLine("Você escolheu o mês de Novembro e é PRIMAVERA !!!");
        break;

    case 12:
        Console.WriteLine("Você escolheu o mês de Dezembro e é VERÃO !!!");
        break;



    default:
        Console.WriteLine("O núemro escolhido não é permitido");
        break;
}

//Finalizar o programa

Console.WriteLine("Digite uma tecla para encerrar o programa");
Console.Read();


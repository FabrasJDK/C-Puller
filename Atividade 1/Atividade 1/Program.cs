
string[] diasemana = new string[] {


    "Segunda",
    "Terça",
    "Quarta ",
    "Quinta",
    "Sexta",
    "Sabado",
    "Domingo" };

string[] tarefa = new string[7];

for (int i = 0; i < diasemana.Length; i++)
{
    Console.Write($"Digite a tarefa para {diasemana[i]}: ");
    tarefa[i] = Console.ReadLine();
}

Console.WriteLine("\nTarefas da semana:");
for (int i = 0; i < diasemana.Length; i++)
{

    Console.WriteLine($"{diasemana[i]}: {tarefa[i]}");

}

Console.ReadKey();


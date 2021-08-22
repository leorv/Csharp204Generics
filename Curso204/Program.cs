// See https://aka.ms/new-console-template for more information

using Curso204;

PrintService ps = new PrintService();

Console.WriteLine("How many values: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    ps.AddValue(x);
}

ps.Print();

Console.WriteLine("First: " + ps.First());

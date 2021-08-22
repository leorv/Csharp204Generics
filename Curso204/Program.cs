// See https://aka.ms/new-console-template for more information

using Curso204;

PrintService<int> ps = new PrintService<int>();

Console.WriteLine("How many values: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    ps.AddValue(x);
}

ps.Print();

int a = ps.First();

Console.WriteLine("First: " + ps.First());

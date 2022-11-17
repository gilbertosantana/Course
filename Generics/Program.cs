using Generics;

PrintService<int> ps = new PrintService<int>();

Console.WriteLine("How many values?");

int quantValues = int.Parse(Console.ReadLine()!);

for (int i = 0; i < quantValues; i++)
{
    int value = int.Parse(Console.ReadLine()!);
    ps.AddValue(value);
}
ps.Print();
Console.WriteLine("First: " + ps.First());

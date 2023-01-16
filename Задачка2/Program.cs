Console.Clear();
Console.Write("number a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("number b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("number c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;
    Console.WriteLine($"max = {max}");
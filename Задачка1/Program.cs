Console.Clear();
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"{a}");
}
else if(b > a)
{
    Console.WriteLine($"{b}");
}
else
{
    Console.WriteLine("Числа равны");
}
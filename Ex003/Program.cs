Console.WriteLine("Введите день недели Например 1 -> Monday");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Monday");
}
if (n == 2)
{
    Console.WriteLine("Tuesday");
}
if (n == 3)
{
    Console.WriteLine("Wednesday");
}
if (n == 4)
{
    Console.WriteLine("Thursday");
}
if (n == 5)
{
    Console.WriteLine("Friday");
}
if (n == 6)
{
    Console.WriteLine("Saturday");
}
if (n == 7)
{
    Console.WriteLine("Sunday");
}
if (n > 7)
{
    Console.WriteLine("Такого дня недели нет )))");
}
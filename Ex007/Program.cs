Console.WriteLine("Введите целое трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100 | n > 999)
{
    Console.WriteLine("Введите целое трехзначное число");
}
else 
{
    Console.Write("Последнее число = " + Convert.ToInt32(n%10));
}
Console.WriteLine("Введите день недели Например 1 -> Monday");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("Monday");
}
else if (n == 2)
{
    Console.WriteLine("Tuesday");
}
else if (n == 3)
{
    Console.WriteLine("Wednesday");
}
else if (n == 4)
{
    Console.WriteLine("Thursday");
}
else if (n == 5)
{
    Console.WriteLine("Friday");
}
else if (n == 6)
{
    Console.WriteLine("Saturday");
}
else if (n == 7)
{
    Console.WriteLine("Sunday");
}
else  
{
    Console.WriteLine("Такого дня недели нет )))");
}

// Console.WriteLine("Введите день недели Например 1 -> Понедельник");
//         int a = Convert.ToInt32(Console.ReadLine());
//         switch (a)
//         {
//             case 1:
//                 Console.WriteLine("Понедельник");
//                 break;
//             case 2:
//                 Console.WriteLine("Вторник");
//                 break;
//             case 3:
//                 Console.WriteLine("Среда");
//                 break;
//             case 4:
//                 Console.WriteLine("Четверг");
//                 break;
//             case 5:
//                 Console.WriteLine("Пятница");
//                 break;
//             case 6:
//                 Console.WriteLine("Суббота");
//                 break;
//             case 7:
//                 Console.WriteLine("Воскресенье");
//                 break;
//                 default:
//                 Console.WriteLine("Вы ввели не коректное число");
//                 break;
//         }
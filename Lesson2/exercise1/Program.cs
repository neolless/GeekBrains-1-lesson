//ryzhuk
//Написать программу, возвращающую минимальное
//из трёх чисел
Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write ("b= ");
int b = int.Parse(Console.ReadLine());
Console.Write ("c= ");
int c = int.Parse(Console.ReadLine());
int min = 0;
if (a < b && a < c)
{
    min = a;
}
else if (b < a && b < c)
{
    min = b;
}
else {
    min = c;
}
Console.WriteLine($"Минимальное число : {min} !");


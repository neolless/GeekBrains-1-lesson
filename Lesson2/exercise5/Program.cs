//Ryzhuk
// Написать программу, которая запрашивает массу и рост человека, 
// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
// набрать вес или всё в норме.

Console.WriteLine("Введите свой вес в килограммах : ");
int userWeight = int.Parse(Console.ReadLine());
Console.WriteLine("Введите свой рост в метрах : ");
double userHeight = Convert.ToDouble(Console.ReadLine());
double imt= Convert.ToDouble(userWeight/(userHeight*userHeight));
int max = 25;
int min = 18;

if (imt > max)
{
Console.WriteLine("Избыточная масса тела ");
}
else if (imt < min)
{
Console.WriteLine("Недостаточная масса тела ");
}
else 
Console.WriteLine("Ты в норме");



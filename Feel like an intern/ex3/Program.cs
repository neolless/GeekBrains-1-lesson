// Ryzhuk
//По заданному номеру дня недели вывести его название

using System;
class Name
{
    enum Days{
     None=0,
              Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
     };
static void Main()
{
Console.Write ("Введите число :");
int userN = int.Parse(Console.ReadLine());
Console.WriteLine((Days)userN);
    }
}

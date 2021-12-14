//Ryzhuk
//Написать программу подсчета
//количества цифр числа

Console.Write ("Введите число : ");
int num = int.Parse(Console.ReadLine());
int i = 0;
for (i=0; num>0; i++)
{
    num/=10;
}
Console.WriteLine($"Количество цифр введенного вами числа равна : {i}");
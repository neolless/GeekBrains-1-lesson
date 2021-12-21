//Ryzhuk
//Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число : "); 
int userNumb1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите второе число : "); 
int userNumb2 = int.Parse(Console.ReadLine()); 

if (userNumb1>userNumb2)
Console.WriteLine ($"Число {userNumb1} больше {userNumb2}");
else
Console.WriteLine ($"Число {userNumb2} больше {userNumb1}");
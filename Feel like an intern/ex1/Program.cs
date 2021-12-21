//Ryzhuk
//По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число : "); 
int userNumb1 = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите второе число : "); 
int userNumb2 = int.Parse(Console.ReadLine()); 
if (userNumb1 == userNumb2*userNumb2)
Console.WriteLine ($"Число {userNumb1} является квадратом {userNumb2}");
else
Console.WriteLine ($"Число {userNumb1} не является квадратом {userNumb2}");
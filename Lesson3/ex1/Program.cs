//Ryzhuk
//а) дописать структуру Complex, добавив метод вычитания комплексных чисел.
//Продемонстрировать работу структуры
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса. 


class Program {

  static void Main (){

   Complex z1 = new Complex(1,-2); //первое комплексное число
  Complex z2 = new (3,-4); //второе комплексное число

  Complex z3;
  z3=z1.Sum(z2);// сумма

   Complex z4;
  z4=z1.Des(z2);// вычитание

  Complex z5;
  z5=z1.Mult(z2); // умножение

  System.Console.WriteLine("Введите цифру 1 для сложения чисел, цифру 2 для вычитания, цифру 3 для умножения");
int user_input= Convert.ToInt32(System.Console.ReadLine());

switch (user_input) {

  case 1:
System.Console.WriteLine($"Сложение чисел :  {z3}");
break;
  case 2:
System.Console.WriteLine($"Вычитание чисел :  {z4}");
break;
  case 3:
System.Console.WriteLine($"Умножение чисел :  {z5}");
break;
}
}
}
 
//Ryzhuk
//С клавиатуры вводятся числа, пока не будет введен 0.
// Подсчитать сумму всех нечетных положительных чисел
   
   int b = 0;
   while (true)
   {
  int a = Convert.ToInt16(Console.ReadLine());             
   if (a != 0)
   {
   if (a % 2 == 0)
  { }
   else
   b += a;
   }
   else
  {
  break;
   }
}
Console.WriteLine(b);
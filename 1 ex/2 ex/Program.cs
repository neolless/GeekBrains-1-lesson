//Ryzhuk
// Ввести вес и рост человека. Рассчитать и вывести индекc
//массы тела. Где m - масса в кг; h - рост в метрах;
Console.WriteLine("Введите свой вес");
string weight = Console.ReadLine();
double m;
m = Convert.ToDouble(weight);
Console.WriteLine("Введите свой рост");
string height = Console.ReadLine();
double h;
h = Convert.ToDouble(height);
double i = m/(h*h);
Console.WriteLine($"Индекс массы тела : {i:F3} ! ");

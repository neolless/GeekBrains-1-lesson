//Ryzhuk
// Последовательно задаются вопросы. В результате вся информация
//выводится в одну строчку
//- используя склеивание;
//- используя форматированный вывод;
//- используя вывод со знаком $;

Console.WriteLine("Введите свое имя : ");
string name = Console.ReadLine();
Console.WriteLine ("Введите свою фамилию : ");
string surname = Console.ReadLine();
Console.WriteLine ("Введите свой возраст : ");
string age = Console.ReadLine();
Console.WriteLine ("Введите свой рост : ");
string height = Console.ReadLine();
Console.WriteLine ("Введите свой вес : ");
string weight = Console.ReadLine();


Console.WriteLine (name + surname + age + height + weight );
string format = String.Format("{0} {1} {2} {3} {4}",name, surname, age, height, weight);
Console.WriteLine (format);
Console.WriteLine ($"{name} {surname} {age} {height} {weight}");


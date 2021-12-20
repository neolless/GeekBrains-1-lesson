//Ryzhuk
//реализовать метод проверки логина и пароля. На вход метода подается логин и пароль
//На выходе истина, если пользователь прошел авторизацию,
//и ложь если не прошел. С помощью цикла do while
//ограничить ввод пароля 3-мя попытками

string log = "root";
string password = "GeekBrains";
int i = 0;
do {

Console.WriteLine("Введите логин : ");
string userLog = Console.ReadLine();
Console.WriteLine("Введите пароль : ");
string userPassword = Console.ReadLine();
if (log == userLog && password == userPassword)
Console.WriteLine("Вы прошли авторизацию");
else i++;
}
while (i<3);
Console.WriteLine("Вы  не прошли авторизацию");
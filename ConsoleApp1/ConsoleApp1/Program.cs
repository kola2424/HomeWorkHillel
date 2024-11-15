Console.WriteLine("Напиши первое число");
string chislo1 = Console.ReadLine();
Console.WriteLine("Выбери знак написав число под котором он находится 1/ , 2* , 3+ , 4-");
string znak = Console.ReadLine();
Console.WriteLine("Напиши второе число");
string chislo2 = Console.ReadLine();
int num2 = int.Parse(chislo2);
int num1 = int.Parse(chislo1);
int znak1 = int.Parse(znak);
switch (znak1)
{
    case 1:
        Console.WriteLine(num1 / num2);
        break;
    case 2:
        Console.WriteLine(num1 * num2);
        break;
    case 3:
        Console.WriteLine(num1 + num2);
        break;
    case 4:
        Console.WriteLine(num1 - num2);
        break;
    default:
        Console.WriteLine("Неизвестный знак");
        break;
}
// конец первой  и начало второй



Console.WriteLine("Выбери число от 1 до 7"); // дни недели из чисел 
string daynum = Console.ReadLine();
int day = int.Parse(daynum);
string dayName = day switch
{
    1 => "Понеделник",
    2 => "Вторник",
    3 => "Cреда",
    4 => "Четверг",
    5 => "Пятница",
    6 => "суббота",
    7 => "Воскресенье",
    _ => "Это число больше 7"
};
Console.WriteLine(dayName);
//Console.WriteLine("Напиши первое число");
//string chislo1 = Console.ReadLine();
//Console.WriteLine("Выбери знак написав число под котором он находится 1/ , 2* , 3+ , 4-");
//string znak = Console.ReadLine();
//Console.WriteLine("Напиши второе число");
//string chislo2 = Console.ReadLine();
//int num1;
//int num2;
//int znak1;


//int.TryParse(chislo2, out num2);
//int.TryParse(znak, out znak1);
//int.TryParse(chislo1, out num1);

//switch (znak1)
//{
//    case 1:
//        try
//        {
//            int finish = num1 / num2;
//            Console.WriteLine(finish);
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        break;
//    case 2:
//        Console.WriteLine(num1 * num2);
//        break;
//    case 3:
//        Console.WriteLine(num1 + num2);
//        break;
//    case 4:
//        Console.WriteLine(num1 - num2);
//        break;
//    default:
//        Console.WriteLine("Неизвестный знак");
//        break;
//}
//конец первой  и начало второй
Console.WriteLine("Напиши  число для проверки форматов ");
string nummber1 = Console.ReadLine();
byte numm1;
sbyte nummm1;
short numm4;
ushort nummm4;
int  numm2;
uint nummm2;
long numm3;
ulong nummm3;
try
{
    numm1 = byte.Parse(nummber1);
    Console.WriteLine("byte {0}" ,numm1);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{ 
    Console.WriteLine(ex3.Message);
}
// Дальше одно и тоже просто ctrl + c ctrl +v просто переменые разные
try
{
    nummm1 = sbyte.Parse(nummber1);
    Console.WriteLine("sbyte {0}", nummm1);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{
    Console.WriteLine(ex3.Message);
}
try
{
    numm2 = int.Parse(nummber1);
    Console.WriteLine("int {0}",numm2);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{
    Console.WriteLine(ex3.Message);
}
try
{
    nummm2 = uint.Parse(nummber1);
    Console.WriteLine("uint {0}", nummm2);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{
    Console.WriteLine(ex3.Message);
}
try
{
    nummm3 = ulong.Parse(nummber1);
    Console.WriteLine("ulong {0}", nummm3);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{
    Console.WriteLine(ex3.Message);
}
try
{
    numm3 = long.Parse(nummber1);
    Console.WriteLine("long {0}", numm3);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{
    Console.WriteLine(ex3.Message);
}
try
{
    nummm4 = ushort.Parse(nummber1);
    Console.WriteLine("ushort {0}", nummm4);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{
    Console.WriteLine(ex3.Message);
}
try
{
    numm4 = short.Parse(nummber1);
    Console.WriteLine("short {0}", numm4);
}
catch (FormatException ex2)
{
    Console.WriteLine(ex2.Message);
}
catch (OverflowException ex3)
{
    Console.WriteLine(ex3.Message);
}












//Console.WriteLine("Выбери число от 1 до 7"); // дни недели из чисел 
//string daynum = Console.ReadLine();
//int day = int.Parse(daynum);
//string dayName = day switch
//{
//    1 => "Понеделник",
//    2 => "Вторник",
//    3 => "Cреда",
//    4 => "Четверг",
//    5 => "Пятница",
//    6 => "суббота",
//    7 => "Воскресенье",
//    _ => "Это число больше 7"
//};
//Console.WriteLine(dayName);
//Console.WriteLine("Ведите количество сотрудников");
//int sotrudnik;
//int.TryParse(Console.ReadLine(), out sotrudnik);
//Console.WriteLine("Ведите зарплату каждого ");
//int zarplata = 0 ;
//int sredZarplata = 0;
//int exit = 0;
//for (int i = 0; i < sotrudnik+1 ; i++)
//{
//    if (i < sotrudnik)
//    {
//        int.TryParse(Console.ReadLine(), out zarplata);
//        sredZarplata += zarplata;       
//    }
//    else
//    {
//        Console.WriteLine("Средняя зарплата:" +sredZarplata / sotrudnik);
//    }
//}
// end 1 and start 2
//Console.WriteLine("Ведите количество рядков");
//int Zvezda;
//int.TryParse (Console.ReadLine(),out Zvezda);
//for (int i = 0; i <= Zvezda; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
// end 2 and start (3 )
//Console.WriteLine("");
//int num3;
//int.TryParse(Console.ReadLine(), out num3);
//for (int i = 2; i <= num3; i++)
//{
//    bool isPrime = true;
//    for (int j = 2; j*j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//    if (isPrime)
//    {
//        Console.WriteLine(i + "");
//    }
//}
//end 3 start 4  не придумал как это сделать так что пока сдам так что бы долгов было меньше
//end 4 start 5
//    Console.WriteLine("Фибоначивская последовательность:");
//int first = 0;
//int second = 1;
//for (int i = 0; i < 10; i++)
//{
//    first += second;
//    Console.Write(first + " ");
//    second += first;
//    Console.Write(second + " ");
//}
//end 5 start 6
//Console.WriteLine("Введите сколько получаете за час работы:");
//int za4as;
//int.TryParse(Console.ReadLine(), out za4as);
//Console.WriteLine("Сколько часов пропаботал:");
//int Hours;
//int.TryParse(Console.ReadLine(), out Hours);
//Console.WriteLine("Вот сколько ты получишь:" + za4as * Hours);
//end 6 start 7
//    Console.WriteLine("Введите число:");
//int nummber;
//int.TryParse(Console.ReadLine(), out nummber);
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("{0} * {2}= {1}", i, nummber * i, nummber);
//}
//end 7 start 8
//    Console.Write("Введите число: ");
//int number;
//int.TryParse(Console.ReadLine(), out number);
//bool isPrime8 = true;
//if (number <= 1)
//{
//    isPrime8 = false;
//}
//else if (number <= 3)
//{
//    isPrime8 = true;
//}
//else if (number % 2 == 0 || number % 3 == 0)
//{
//    isPrime8 = false;
//}
//else
//{
//    for (int i = 5; i * i <= number; i += 6)
//    {
//        if (number % i == 0 || number % (i + 2) == 0)
//        {
//            isPrime8 = false;
//            break;
//        }
//    }
//}
//if (isPrime8)
//{
//    Console.WriteLine($"Простое число :{number} ");
//}
//else
//{
//    Console.WriteLine($" не простое число: {number}");
//}




































// Прошлые работы
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
////Console.WriteLine("Напиши  число для проверки форматов ");
////string nummber1 = Console.ReadLine();
////byte numm1;
////sbyte nummm1;
////short numm4;
////ushort nummm4;
////int  numm2;
////uint nummm2;
////long numm3;
////ulong nummm3;
////try
////{
////    numm1 = byte.Parse(nummber1);
////    Console.WriteLine("byte {0}" ,numm1);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{ 
////    Console.WriteLine(ex3.Message);
////}
////// Дальше одно и тоже просто ctrl + c ctrl +v просто переменые разные
////try
////{
////    nummm1 = sbyte.Parse(nummber1);
////    Console.WriteLine("sbyte {0}", nummm1);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{
////    Console.WriteLine(ex3.Message);
////}
////try
////{
////    numm2 = int.Parse(nummber1);
////    Console.WriteLine("int {0}",numm2);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{
////    Console.WriteLine(ex3.Message);
////}
////try
////{
////    nummm2 = uint.Parse(nummber1);
////    Console.WriteLine("uint {0}", nummm2);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{
////    Console.WriteLine(ex3.Message);
////}
////try
////{
////    nummm3 = ulong.Parse(nummber1);
////    Console.WriteLine("ulong {0}", nummm3);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{
////    Console.WriteLine(ex3.Message);
////}
////try
////{
////    numm3 = long.Parse(nummber1);
////    Console.WriteLine("long {0}", numm3);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{
////    Console.WriteLine(ex3.Message);
////}
////try
////{
////    nummm4 = ushort.Parse(nummber1);
////    Console.WriteLine("ushort {0}", nummm4);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{
////    Console.WriteLine(ex3.Message);
////}
////try
////{
////    numm4 = short.Parse(nummber1);
////    Console.WriteLine("short {0}", numm4);
////}
////catch (FormatException ex2)
////{
////    Console.WriteLine(ex2.Message);
////}
////catch (OverflowException ex3)
////{
////    Console.WriteLine(ex3.Message);
////}












////Console.WriteLine("Выбери число от 1 до 7"); // дни недели из чисел 
////string daynum = Console.ReadLine();
////int day = int.Parse(daynum);
////string dayName = day switch
////{
////    1 => "Понеделник",
////    2 => "Вторник",
////    3 => "Cреда",
////    4 => "Четверг",
////    5 => "Пятница",
////    6 => "суббота",
////    7 => "Воскресенье",
////    _ => "Это число больше 7"
////};
////Console.WriteLine(dayName);
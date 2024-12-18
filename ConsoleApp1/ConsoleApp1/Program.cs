//Работа с масивами 1
// первое

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Random rnd = new Random();
//int[] array = new int[10];
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = rnd.Next(-10,10);
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"Вывод чисел под парным индексом {i} : " + array[i]);
//    }
//}

//// второе

//int sumArray = array.Sum();  
//if (sumArray <= 0)
//{
//    Console.WriteLine($"Сумма чисел отрицательная : {sumArray}");
//}
//else
//{
//    Console.WriteLine($"Сумма чисел положительная: {sumArray}");
//}

// Третье

//int[][] array9 = new int[9][];
//array9[0] = new int[9];
//array9[1] = new int[9];
//array9[2] = new int[9];
//array9[3] = new int[9];
//array9[4] = new int[9];
//array9[5] = new int[9];
//array9[6] = new int[9];
//array9[7] = new int[9];
//array9[8] = new int[9];
//for (int i = 0;i < array9.Length; i++)
//{
//    array9[0][i] = (i + 1) * 1;
//    array9[1][i] = (i + 1) * 2;
//    array9[2][i] = (i + 1) * 3;
//    array9[3][i] = (i + 1) * 4;
//    array9[4][i] = (i + 1) * 5;
//    array9[5][i] = (i + 1) * 6;
//    array9[6][i] = (i + 1) * 7;
//    array9[7][i] = (i + 1) * 8;
//    array9[8][i] = (i + 1) * 9;
//}
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[0][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[1][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[2][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[3][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[4][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[5][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[6][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[7][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array9.Length; i++)
//{
//    arrayBuilder(array9[8][i]);
//}

// Четвёртое

//int[][] array5 = new int[5][];
//array5[0] = new int[5];
//array5[1] = new int[5];
//array5[2] = new int[5];
//array5[3] = new int[5];
//array5[4] = new int[5];
//for (int i = 0;i < array5.Length; i++)
//{
//    array5[0][i] = rnd.Next(100);
//    array5[1][i] = rnd.Next(100);
//    array5[2][i] = rnd.Next(100);
//    array5[3][i] = rnd.Next(100);
//    array5[4][i] = rnd.Next(100);
//}
//int maxIndex = 0;
//int minIndex = 0;
//int strin = 0;
//int strin2 = 0;
//int maxNum = 0;
//int minNum = 999;
//if (maxNum < array5[0].Max())
//{
//    maxNum = array5[0].Max();
//    maxIndex = Array.IndexOf(array5[0], maxNum);
//    strin = 1;
//}
//if (maxNum < array5[1].Max())
//{
//    maxNum = array5[1].Max();
//    maxIndex = Array.IndexOf(array5[1], maxNum);
//    strin = 2;
//}
//if (maxNum < array5[2].Max())
//{
//    maxNum=array5[2].Max();
//    maxIndex = Array.IndexOf(array5[2], maxNum);
//    strin = 3;
//}
//if (maxNum < array5[3].Max())
//{  
//    maxNum = array5[3].Max();
//    maxIndex = Array.IndexOf(array5[3], maxNum);
//    strin = 4;
//}
//if (maxNum < array5[4].Max())
//{
//    maxNum = array5[4].Max();
//    maxIndex = Array.IndexOf(array5[4], maxNum);
//    strin = 5;

//}
//if (minNum > array5[0].Min())
//{
//    minNum = array5[0].Min();
//    minIndex = Array.IndexOf(array5[0], minNum);
//    strin2 = 1;
//}
//if (minNum > array5[1].Min())
//{
//    minNum = array5[1].Min();
//    minIndex = Array.IndexOf(array5[1], minNum);
//    strin2 = 2 ;
//}
//if (minNum > array5[2].Min())
//{
//    minNum = array5[2].Min();
//    minIndex = Array.IndexOf(array5[2], minNum);
//    strin2 = 3;
//}
//if (minNum > array5[3].Min())
//{
//    minNum = array5[3].Min();
//    minIndex = Array.IndexOf(array5[3], minNum);
//    strin2 = 4;
//}
//if (minNum > array5[4].Min())
//{
//    minNum = array5[4].Min();
//    minIndex = Array.IndexOf(array5[4], minNum);
//    strin2 = 5;
//}
//for (int i = 0; i < array5.Length; i++)
//{
//    arrayBuilder(array5[0][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array5.Length; i++)
//{
//    arrayBuilder(array5[1][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array5.Length; i++)
//{
//    arrayBuilder(array5[2][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array5.Length; i++)
//{
//    arrayBuilder(array5[3][i]);
//}
//Console.WriteLine("");
//for (int i = 0; i < array5.Length; i++)
//{
//    arrayBuilder(array5[4][i]);
//}
//Console.WriteLine("");
//Console.WriteLine(maxNum);
//Console.WriteLine(" ");
//Console.WriteLine($"максимальный индекс на рядке {strin} и по счёту {maxIndex + 1 } само число {maxNum}");
//Console.WriteLine($"мИнимальный индекс на рядке {strin2} и по счёту {minIndex + 1} само число {minNum}");

//  Пятое

int day = 0;
int.TryParse(Console.ReadLine(), out day);
if (day % 7  == 7)
{
    Console.WriteLine("Sunday");
}
else if (day % 7 == 6)
{
    Console.WriteLine("Saturday");
}
else if (day % 7 == 5)
{
    Console.WriteLine("Friday");
}
else if (day % 7 == 4)
{
    Console.WriteLine("Thersday");
}
else if (day % 7 == 3)
{
    Console.WriteLine("Wednesday");
}
else if (day % 7 == 2)
{
    Console.WriteLine("Tuesday");
}
else if (day % 7 == 1)
{
    Console.WriteLine("Monday");
}
OrderType days = OrderType.Wednesday;
if (days == OrderType.Monday)
{
    Console.WriteLine("Monday");
}
else if (days == OrderType.Tuesday)
{
    Console.WriteLine("Tuesday");
}
else if (days == OrderType.Wednesday)
{
    Console.WriteLine("Wednesday");
}
else if (days== OrderType.Thursday)
{
    Console.WriteLine("Thersday");
}
else if (days == OrderType.Friday)
{
    Console.WriteLine("Friday");
}
else if (days == OrderType.Saturday)
{
    Console.WriteLine("Saturday");
}
else
{
    Console.WriteLine("Sunday");
}
enum OrderType
{
    Monday = 1 ,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday

}


















































//static void arrayBuilder(int num)
//{
//        Console.Write(num + " ");

//}


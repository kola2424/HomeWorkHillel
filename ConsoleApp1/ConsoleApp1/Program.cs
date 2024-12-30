//using System.Linq;
//using System.Numerics;

// Первое

//int[] array = new int[10];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0 , 250);
//    Console.Write($"{array[i]} ");
//}
//Console.WriteLine();
//int max = 0;
//int max2 = 0;
//foreach (int i in array)
//{
//    if (i > max )
//    {
//        max = i;
//    }
//    if ( i > max2 && i != max) 
//    {  
//        max2 = i;
//    }
//}
//Console.WriteLine($"Максимальное число :{max}");
//Console.WriteLine($"Второе максимальное число: {max2}");

// Второе 

//int[][] array2 = new int[2][];
//array2[0] = new int[10];
//array2[1] = new int[10];
//for (int i = 0; i < array2[0].Length; i++)
//{
//    array2[0][i] = random.Next(0, 125);
//    array2[1][i] = random.Next(0, 125);
//}

//array2[0] = array2[0].OrderByDescending(x => x).ToArray();
//array2[1] = array2[1].OrderByDescending(x => x).ToArray();
//for (int i = 0; i < array2[0].Length; i++)
//{
//    int temp = 0;
//    if (array2[0][i] < array2[1][i])
//    {
//        temp = array2[0][i];
//        array2[0][i] = array2[1][i];
//        array2[1][i] = temp;
//    }
//    if (array2[0][array2[0].Length - 1 - i] < array2[1][i])
//    {
//        temp = array2[1][i];
//        array2[1][i] = array2[0][array2[0].Length - 1 - i];
//        array2[0][array2[0].Length - 1 - i] = temp;
//    }
//}
//array2[0] = array2[0].OrderByDescending(x => x).ToArray();
//array2[1] = array2[1].OrderByDescending(x => x).ToArray();


//for (int i = 0; i < array2[0].Length; i++)
//{
//    Console.Write($"{array2[0][i]} ");
//}
//Console.WriteLine("");
//for (int i = 0; i < array2[0].Length; i++)
//{
//    Console.Write($"{array2[1][i]} ");
//} // Вывод масивов для проверки 

// Третье 

//int[] array3 = new int[10];
//Console.WriteLine("Масив:");
//for (int i = 0; i < array.Length; i++)
//{
//    array3[i] = random.Next(1, 250);
//    Console.Write($"{array3[i]} ");
//}
//Console.WriteLine("");
//Console.WriteLine("Введите номер числа которое хотите удалить ");
//int deletenum = 0;
//int.TryParse(Console.ReadLine(), out deletenum);
//array3[deletenum -1 ] = 0;
//Console.WriteLine("Элемент был удалён успешно");
//Console.WriteLine("Масив:");
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"{array3[i]} ");
//}

////  Четвёртое

//int[][] array4 = new int[3][];
//array4[0] = new int[10];
//array4[1] = new int[10];
//array4[2] = new int[10];
//for (int i = 0; i < array4[0].Length; i++)
//{
//    array4[0][i] = random.Next(0, 100);
//    array4[1][i] = random.Next(0, 100);
//    array4[2][i] = random.Next(0, 100);

//}
//int sum = 0;
//for (int i = 0;i < array4[0].Length;i++)
//{
//    if( i == 0 )
//    {
//        sum += array4[0][i];
//    }
//    if (i == 1)
//    {
//        sum += array4[0][i] + array4[1][i - 1];
//    }
//    if (i >= 2)
//    {
//        sum += array4[0][i] + array4[1][i - 1]+ array4[2][i-2]; 
//    }
//    Console.WriteLine(sum);

//}





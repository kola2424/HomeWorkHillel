namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] array = new int[2][];
            array[0] = new int[10];
            array[1] = new int[10];
            // задание 1  второй найбольший элемент
            for (int i = 0; i < 10; i++)
            {
                array[0][i] = rnd.Next(0, 50);
                array[1][i] = rnd.Next(0, 50);
            }
            int max2 = -1;
            int max = -1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[0][i] + "(");
                Console.Write(array[1][i]+")");


                int next = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (max < array[0][i])
                    {
                        max = array[0][i];
                    }
                }


                
                if (max < array[1][i])
                {
                    max = array[1][i];
                }


                if (max2 < array[0][i] && max2 != max && array[0][i] > array[1][i])
                {
                    max2 = array[0][i];
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine(max2);
        }
    }
}

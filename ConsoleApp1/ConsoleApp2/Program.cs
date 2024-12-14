namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fibonachi = 0;
            int.TryParse(Console.ReadLine(), out fibonachi);
            int endFibonachi = Fibonachi(fibonachi);
            Console.WriteLine($"Число фибоначи ={endFibonachi} пoсле {fibonachi} раз");
        }
        static int Fibonachi(int number)
        {
            if (number <= 1)
                return number;
            int prev = 0, next = 1;
            for (int i = 2; i < number; i++)
            {
                int temp = prev + next;
                prev = next;
                next = temp;
            }
            return next;
        }
    }
}

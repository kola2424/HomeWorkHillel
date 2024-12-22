using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account user = new Account();
            Console.WriteLine("Введите Имя");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию ");
            user.Surname = Console.ReadLine();     
            Console.WriteLine("Введите Первоначальный взнос");
            int cash = 0;
            int.TryParse(Console.ReadLine(), out cash);
            user.Cash = cash;
            Console.WriteLine($"  Счёт {user.Name} {user.Surname} = {user.Cash}");
            Console.WriteLine("Напишите число которое хотите  забрать"); 
            int sum = 0;
            int.TryParse(Console.ReadLine(), out sum);
            user.withdraw(sum);
            Console.Write($"денег на счету :");
            user.CashInfo();
            Console.WriteLine("Напишите число которое хотите  положить");
            int.TryParse(Console.ReadLine(), out sum);
            user.deposit(sum);
            user.CashInfo();

            Account user2 = new Account();
            Console.WriteLine("Введите Имя");
            user2.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию ");
            user2.Surname = Console.ReadLine();
            Console.WriteLine("Введите Первоначальный взнос");
            cash = 0;
            int.TryParse(Console.ReadLine(), out cash);
            user2.Cash = cash;
            Console.WriteLine($"  Счёт {user2.Name} {user2.Surname} = {user2.Cash}");
            Console.WriteLine("Напишите число которое хотите  забрать");
            sum = 0;
            int.TryParse(Console.ReadLine(), out sum);
            user2.withdraw(sum);
            Console.Write($"денег на счету :");
            user2.CashInfo();
            Console.WriteLine("Напишите число которое хотите  положить");
            int.TryParse(Console.ReadLine(), out sum);
            user2.deposit(sum);
            Console.Write($"денег на счету :");
            user2.CashInfo();


        }
    }
}

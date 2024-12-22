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

            retyrn1:

            Console.WriteLine("Введите Первоначальный взнос");
            int cash = 0;
            int.TryParse(Console.ReadLine(), out cash);
            user.Cash = cash;
            Console.WriteLine($"  Счёт {user.Name} {user.Surname} = {user.Cash}");
            Console.WriteLine("Напишите число которое хотите положить или забрать(забрать через -)"); // ну я сделал добавление и отнимания на счёт 
            int sum = 0;
            int.TryParse(Console.ReadLine(), out sum);
            user.Cash = sum;
            user.CashInfo();
            Console.WriteLine("Хотите ли дальше продолжить работу? выберите Да или Нет");
            if (Console.ReadLine() == "Да")
            {
                goto retyrn1;
            }
            else if (Console.ReadLine() == "Нет")
            {
                Console.WriteLine("Досвидание ");
            }
            else
            {
                Console.WriteLine("Не верная команда принудительное закрытие ");
            }
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

            retyrn2: 

            Console.WriteLine("Напишите число которое хотите положить или забрать(забрать через -)");  
            sum = 0;
            int.TryParse(Console.ReadLine(), out sum);
            user2.Cash = sum;
            user2.CashInfo();
            Console.WriteLine("Хотите ли дальше продолжить работу? выберите Да или Нет");
            if (Console.ReadLine() =="Да")
            {
                goto retyrn2;
            }
            else if (Console.ReadLine() == "Нет") 
            {
                Console.WriteLine("Досвидание ");
            }
            else 
            { 
                Console.WriteLine("Не верная команда принудительное закрытие ");
            }

        }
    }
}

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создания списка и ввод дел
            List<string> list = new List<string>();

            Console.WriteLine("Введите в список свои дела");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Введите своё дело под номером {i + 1}");
                list.Add(Console.ReadLine());
            }
            for (int i = 0; i < list.Count; i++) //  Вывод дел
            {

                Console.WriteLine($"Дело под номером{i + 1} {list[i]}");
            }
            Console.WriteLine("Введите номер дела которое вы сделали");// отметка на выполнения задания
            int deletenum = 0;
            int.TryParse(Console.ReadLine(), out deletenum);
            list[deletenum - 1] = list[deletenum -1 ] + " Выполнено";
            for (int i = 0; i < list.Count; i++) //  Вывод дел
            {
                Console.WriteLine($"Дело под номером{i + 1} {list[i]}");
            }
            Console.WriteLine("Введите номер дела которое хотите удалить "); // удаление обьекта 
            deletenum = 0;
            int.TryParse(Console.ReadLine(), out deletenum);
            string temp2 = list[deletenum - 1];
            list.Remove(temp2);
            for (int i = 0; i < list.Count; i++) //  Вывод дел 
            {

                Console.WriteLine($"Дело под номером{i + 1} {list[i]}");
            }

        }
    }
}

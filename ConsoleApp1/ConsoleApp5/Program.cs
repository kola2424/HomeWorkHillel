namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int blok = 0;
            int number = 0;
            string[] game =  { "кот", "мячик", "камень", "футбол", "лошадь" };
            Random random = new Random();
            string word = game[random.Next(0, 4)];
            Console.WriteLine($"В слове :{word.Length} букв");
            for (int i = 0; i < word.Length;)
            {
                Console.WriteLine("Введите букву");
                string lit = Console.ReadLine();
                char lit1 = lit[0];

                if (Game(word, word.Length, lit1) == 0)
                {
                    Console.WriteLine($"Осталось попыток : {word.Length - i-1}");
                    i++;
                }
                else
                {
                    
                    number++;
                }
                if (number == word.Length)
                {
                    Console.Write("Ты победил");
                    break;
                }
                if (i == word.Length)
                {
                    Console.Write("Ты проиграл  ");
                }
            }
            Console.WriteLine($"слово было {word}");

            static int Game(string secret, int num, char lit1)
            {


                for (int i = 0; i < secret.Length; i++)
                {
                    if (secret[i] == lit1)
                    {
                        Console.WriteLine($"Вы угадали букву под номером : {i+1} ");
                        return 1;
                        
                    }


                }
                return 0;
            }

        }
    }
}

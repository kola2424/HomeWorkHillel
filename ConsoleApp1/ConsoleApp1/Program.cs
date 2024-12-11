//Console.WriteLine("Введите Имя и Фамилию");
//string NameLastName = Console.ReadLine();
//char Littera = ' ';
//for (int i = 0; i < NameLastName.Length; i++)
//    if (NameLastName[i] == ' ')
//    {
//        Littera = NameLastName[i+1];
//        break;
//    }
//    else
//    {
//        continue;
//    }
//if (NameLastName[0] == Littera)
//{
//    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
//}
//else
//{
//    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
//}
// Конец (1)первой начало (2)второй
//using System.Text;
//string end = null;
//string Name = null;
//StringBuilder now = new StringBuilder();
//DateTime utcNow = DateTime.UtcNow;
//for (int i = 1; i < 11; i++)
//{
//    now.Append("Запись: " + i + " " + Console.ReadLine() + " " + utcNow.AddDays(i) + " . ");
//}
//end = now.ToString();
//Console.WriteLine(end);
// Конец  (2)второй начало 3
//Console.WriteLine("Ведите слова через ,");
//string twoName = Console.ReadLine();
//string newTwoName = twoName.Replace(" ", "");
//Console.WriteLine(newTwoName);
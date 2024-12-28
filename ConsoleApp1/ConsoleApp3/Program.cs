Console.WriteLine("Введите путь к файлу который хотите скопировать");
string input = Console.ReadLine();
string? copy = File.ReadAllText(input);
Console.WriteLine("Ведите путь к файлу в который хотите всё перенести");
string output = Console.ReadLine();
File.WriteAllText(output, copy);
Console.WriteLine("файл скопировано успешно");
using System.Linq.Expressions;

char[][] krestikNolik = new char[3][];
krestikNolik[0] = new char[3]; krestikNolik[0][0] = ' '; krestikNolik[0][1] = ' '; krestikNolik[0][2] = ' ';
krestikNolik[1] = new char[3]; krestikNolik[1][0] = ' '; krestikNolik[1][1] = ' '; krestikNolik[1][2] = ' ';
krestikNolik[2] = new char[3]; krestikNolik[2][0] = ' '; krestikNolik[2][1] = ' '; krestikNolik[2][2] = ' ';

int step = 0;
bool step1 = true;
bool step2 = true;
bool step3 = true;
bool step4 = true;
bool step5 = true;
bool step6 = true;
bool step7 = true;
bool step8 = true;
bool step9 = true;
Console.WriteLine("Игра в крестики нолики ");
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(krestikNolik[0][j] + " | ");
    }
    Console.WriteLine("");

    for (int j = 0; j < 3; j++)
    {
        Console.Write(krestikNolik[1][j] + " | ");
    }
    Console.WriteLine("");


    for (int j = 0; j < 3; j++)
    {
        Console.Write(krestikNolik[2][j] + " | ");
    }
    Console.WriteLine("Выберите клетку для хода от 1 до 9");
    int.TryParse(Console.ReadLine(), out step);
    if (i % 2 == 0)
    {
        if (step == 1 && step1)
        {
            krestikNolik[0][0] = 'X';
            step1 = false;
        }
        else if (step == 2 && step2)
        {
            krestikNolik[0][1] = 'X';
            step2 = false;
        }
        else if (step == 3 && step3)
        {
            krestikNolik[0][2] = 'X';
            step2 = false;
        }
        else if (step == 4 && step4)
        {
            krestikNolik[1][0] = 'X';
            step4 = false;
        }
        else if (step == 5 && step5)
        {
            krestikNolik[1][1] = 'X';
            step5 = false;
        }
        else if (step == 6 && step6)
        {
            krestikNolik[1][2] = 'X';
            step6 = false;
        }
        else if (step == 7 && step7)
        {
            krestikNolik[2][0] = 'X';
            step7 = false;
        }
        else if (step == 8 && step8)
        {
            krestikNolik[2][1] = 'X';
            step2 = false;
        }
        else if (step == 9 && step9)
        {
            krestikNolik[2][2] = 'X';
            step9 = false;
        }
    }
    else
    {
        if (step == 1 && step1)
        {
            krestikNolik[0][0] = 'O';
            step1 = false;
        }
        else if (step == 2 && step2)
        {
            krestikNolik[0][1] = 'O';
            step2 = false;
        }
        else if (step == 3 && step3)
        {
            krestikNolik[0][2] = 'O';
            step2 = false;
        }
        else if (step == 4 && step4)
        {
            krestikNolik[1][0] = 'O';
            step4 = false;
        }
        else if (step == 5 && step5)
        {
            krestikNolik[1][1] = 'O';
            step5 = false;
        }
        else if (step == 6 && step6)
        {
            krestikNolik[1][2] = 'O';
            step6 = false;
        }
        else if (step == 7 && step7)
        {
            krestikNolik[2][0] = 'O';
            step7 = false;
        }
        else if (step == 8 && step8)
        {
            krestikNolik[2][1] = 'O';
            step2 = false;
        }
        else if (step == 9 && step9)
        {
            krestikNolik[2][2] = 'O';
            step9 = false;
        }

    }
    if (krestikNolik[0][0] == krestikNolik[0][1] && krestikNolik[0][1] == krestikNolik[0][2] && krestikNolik[0][0] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }
    if (krestikNolik[1][0] == krestikNolik[1][1] && krestikNolik[1][1] == krestikNolik[1][2] && krestikNolik[1][0] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }
    if (krestikNolik[2][0] == krestikNolik[2][1] && krestikNolik[2][1] == krestikNolik[2][2] && krestikNolik[2][0] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }
    if (krestikNolik[0][0] == krestikNolik[1][1] && krestikNolik[1][1] == krestikNolik[2][2] && krestikNolik[0][0] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }
    if (krestikNolik[0][2] == krestikNolik[1][1] && krestikNolik[1][1] == krestikNolik[2][0] && krestikNolik[0][2] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }
    if (krestikNolik[0][0] == krestikNolik[1][0] && krestikNolik[0][0] == krestikNolik[2][0] && krestikNolik[0][0] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }
    if (krestikNolik[0][1] == krestikNolik[1][1] && krestikNolik[0][1] == krestikNolik[2][1] && krestikNolik[0][1] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }
    if (krestikNolik[0][2] == krestikNolik[1][2] && krestikNolik[0][2] == krestikNolik[2][2] && krestikNolik[0][2] == 'O')
    {
        Console.WriteLine("Нолик победил");
        break;
    }

    if (krestikNolik[0][0] == krestikNolik[1][0] && krestikNolik[0][0] == krestikNolik[2][0] && krestikNolik[0][0] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (krestikNolik[0][1] == krestikNolik[1][1] && krestikNolik[0][1] == krestikNolik[2][1] && krestikNolik[0][1] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (krestikNolik[0][2] == krestikNolik[1][2] && krestikNolik[0][2] == krestikNolik[2][2] && krestikNolik[0][2] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (krestikNolik[0][0] == krestikNolik[0][1] && krestikNolik[0][1] == krestikNolik[0][2] && krestikNolik[0][0] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (krestikNolik[1][0] == krestikNolik[1][1] && krestikNolik[1][1] == krestikNolik[1][2] && krestikNolik[1][0] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (krestikNolik[2][0] == krestikNolik[2][1] && krestikNolik[2][1] == krestikNolik[2][2] && krestikNolik[2][0] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (krestikNolik[0][0] == krestikNolik[1][1] && krestikNolik[1][1] == krestikNolik[2][2] && krestikNolik[0][0] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (krestikNolik[0][2] == krestikNolik[1][1] && krestikNolik[1][1] == krestikNolik[2][0] && krestikNolik[0][2] == 'X')
    {
        Console.WriteLine("Крестик победил");
        break;
    }
    if (i == 8)
    {
        Console.WriteLine("Ничья");
    }
}
for (int j = 0; j < 3; j++)
{
    Console.Write(krestikNolik[0][j] + " | ");
}
Console.WriteLine("");


for (int j = 0; j < 3; j++)
{
    Console.Write(krestikNolik[1][j] + " | ");
}
Console.WriteLine("");

for (int j = 0; j < 3; j++)
{
    Console.Write(krestikNolik[2][j] + " | ");
}



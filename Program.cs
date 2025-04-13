using System;
using System.Text.RegularExpressions;


int i=0, j=0, count = 0;
int max_count = 0, k = 0;

Console.WriteLine("Лабораторная работа №1\r\nЗадача 1.1 (задача 3k+1):");
Console.WriteLine("Для выхода из программы введите \"exit\".");


while (true)
{
    Console.Write("Введите i= ");
    string inputI = Console.ReadLine();
    if (inputI == "exit")
        break;
    Console.Write("Введите j= ");
    string inputJ = Console.ReadLine();
    if (inputJ == "exit")
        break;

    string pattern = @"^(?!0+$)\d{1,6}$|^1000000$"; // регулярное выражение
    // проверка i
    if (!Regex.IsMatch(inputI, pattern))
    {
        Console.WriteLine("i — некорректное число. Должно быть целое число от 1 до 1000000!");
        return;
    }
    else
    {
        i = Convert.ToInt32(inputI);
    }
    // проверка j
    if (!Regex.IsMatch(inputJ, pattern))
    {
        Console.WriteLine("j — некорректное число. Должно быть целое число от 1 до 1000000!");
        return;
    }
    else
    {
        j = Convert.ToInt32(inputJ);

    }

    Console.WriteLine("Вычисляем...");
    Console.Write($"{i} {j} ");

    while (true)
    {
        k = i;
        count = 0;

        while (k != 1) // цыкл с главным условием
        {
            if (k % 2 == 0)
            {
                k = k / 2;
                count++;
            }
            else
            {
                k = 3 * k + 1;
                count++;
            }
        }
        if (count > max_count)
        {
            max_count = count;
        }

        if (i == j)
            break;
        i = i < j ? (i += 1) : (i -= 1);
    }
    Console.WriteLine($"{max_count}");
    Console.WriteLine("----------------------");

}



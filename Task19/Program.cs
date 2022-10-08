/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

string s = String.Empty;
Console.WriteLine(s);

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
var line = number.ToString();
var symbols = line.Length;

Console.WriteLine(s);

if (symbols == 5)
{
    if (line[0] == line[4] && line[1] == line[3])
    {
        Console.WriteLine($"Число {number} - является палиндромом");
    }

    else
    {
        Console.WriteLine($"Число {number} - не является полиндромом");
    }
}
else
{
    Console.WriteLine($"Число {number} не соответствует условию задачи");
}

Console.WriteLine(s);


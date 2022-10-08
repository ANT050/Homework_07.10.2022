/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/* ПЕРВЫЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

string s = String.Empty;
Console.WriteLine(s);

void GetExponentiation(int number, int degree)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i}^{degree} = {Math.Pow(i, degree)}");
    }
    Console.WriteLine(s);
}

Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
var degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(s);

GetExponentiation(number, degree);


/* ВТОРОЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

/*string s = String.Empty;
Console.WriteLine(s);

int InputNumber(string message) // Функция ввода сообщения
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputNumber("Введите число: ");
int degree = InputNumber("Введите степень: ");

Console.WriteLine(s);

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i}^{degree} = {Math.Pow(i, degree)}"); //возведение в степень
}

Console.WriteLine(s);*/

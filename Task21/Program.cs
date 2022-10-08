/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

/* ПЕРВЫЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

string s = String.Empty;
Console.WriteLine(s);

int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату X первой точки: ");
int y1 = InputNumber("Введите координату Y первой точки: ");
int z1 = InputNumber("Введите координату Z первой точки: ");

Console.WriteLine(s);

int x2 = InputNumber("Введите координату X второй точки: ");
int y2 = InputNumber("Введите координату Y второй точки: ");
int z2 = InputNumber("Введите координату Z второй точки: ");

Console.WriteLine(s);

double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// Math.Sqrt() - корень квадратный, Math.Pow(a, n) - возведение в степень, где n - степень

string result = string.Format("{0:f2}", distance); //форматирование дробных чисел (f - сколько знаков после запятой)
Console.WriteLine($"Расстояние между точками A и B: {result}\n");

/* ВТОРОЙ СПОСОБ РЕШЕНИЯ ДАННОГО УСЛОВИЯ*/

/*

string s = String.Empty;
Console.WriteLine(s);


Point GetPoint()
{
    Point point = new Point();
    Console.Write("Введите координату X: ");
    point.X = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Y: ");
    point.Y = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Z: ");
    point.Z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(s);

    return point;
}

Point firstPoint = GetPoint();
Point secondPoint = GetPoint();

double distance = Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2) + Math.Pow(secondPoint.Z - firstPoint.Z, 2));
string result = string.Format("{0:f2}", distance); //форматирование дробных чисел (f - сколько знаков после запятой)
Console.WriteLine($"Расстояние между точками A и B: {result}\n");
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public int Z { get; set; }
}

*/
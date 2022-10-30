/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.


void PositiveNumbers()
{
Console.Write("Введите числа: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < size; i++)
{
Console.Write($"Введите число {i + 1} - ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/


void IntersectionPoints()  
{
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"точка пересечения X - {x}");
    Console.WriteLine($"точка пересечения Y - {y}");
}

IntersectionPoints();



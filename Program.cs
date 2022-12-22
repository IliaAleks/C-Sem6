// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Task 41
Console.WriteLine("Task 41");
Console.WriteLine("введите числа через запятую и пробел и нажмите enter:");
string masNumbString=Console.ReadLine();
int[] numbers = masNumbString.Split(',').Select(snum => int.Parse(snum)).ToArray();

int numChisel(int [] masint)
{
    int k=0;
    for (int i=0; i<masint.Length; i++)
    {
    if (masint[i]>0) {++k;}
    
    }
    return k;
}
Console.WriteLine($"Количесвто введеных положительных чисел = {numChisel(numbers)}");
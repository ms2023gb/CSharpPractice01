/*
    Задача 8: Напишите программу, которая на вход принимает число (N),
    а на выходе показывает все чётные числа от 1 до N.
*/

Console.Clear();

Console.WriteLine("Введите число N для вывода всех чётных от 1 до числа N: ");
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 2)
{
    Console.WriteLine($"Для числа N={number}, нет чётных чисел от 1 до N");
}
else
{
    Console.Write($"Все чётные числа, начиная с 1 до {number}: ");
    for (int i = 2; i <= number; i += 2) Console.Write($"{i}, ");
}
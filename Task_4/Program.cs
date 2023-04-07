/*
    Задача 4: Напишите программу, которая принимает
    на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.Clear();

Console.WriteLine("Введите три числа и программа найдет наибольшее");
Console.Write("Введите 1-е число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
int max = numberOne;

Console.Write("Введите 2-е число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberTwo > max) max = numberTwo;

Console.Write("Введите 3-е число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
if (numberThree > max) max = numberThree;

// Ответ выводим, как в задании:
// Console.WriteLine($"{numberOne}, {numberTwo}, {numberThree} -> {max}");

Console.WriteLine($"Наибольшее из трех чисел: {max}");
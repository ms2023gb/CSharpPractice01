/*
    Задача 2: Напишите программу, которая на вход принимает два числа
    и выдаёт, какое число большее, а какое меньшее.
*/
Console.Clear();

Console.WriteLine("Вводим два числа и программа найдет наибольшее");
Console.Write("Введите 1-е число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    // Ответ выводим, как в задании:
    // Console.WriteLine($"a = {numberOne}; b = {numberTwo} -> max = {numberOne}");
    Console.WriteLine($"Наибольшее: {numberOne}");
}
else
{
    // Ответ выводим, как в задании:
    // Console.WriteLine($"a = {numberOne}; b = {numberTwo} -> max = {numberTwo}");
    Console.WriteLine($"Наибольшее: {numberTwo}");
}
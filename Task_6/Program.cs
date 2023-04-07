/*
    Задача 6: Напишите программу, которая на вход принимает 
    число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

Console.Clear();

Console.WriteLine("Введите число для проверки на чётность: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    // Ответ выводим, как в задании:
    // Console.WriteLine($"{number} -> да");
    Console.WriteLine($"Число {number} - чётное");
}
else
{
    // Ответ выводим, как в задании:
    // Console.WriteLine($"{number} -> нет");
    Console.WriteLine($"Число {number} - нечётное");
}
// Напишу программу, которая на вход принимает 
// два целых числа и проверяет, является ли первое число 
// квадратом второго.
//  a = 25, b = 5 => yes
//  a = 2, b = 10 => no 
//  a = 9, b = -3 => yes
//  a = -3, b = 9 => no


Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine()); // нам по заданию нужно получить 2 числа по этому мы пишем две команды вводу от пользователя.

if(num1 == num2 * num2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

// Это не задание просто для наработки рук и для понятие задания

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 + num2)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
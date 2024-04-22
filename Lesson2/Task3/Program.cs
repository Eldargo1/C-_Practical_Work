// напишите программу, которая будет принимать на 
// вход два числа и выводит, является ли первое число
// кратным второму.Если первое число некратно 
// второму, то программа выводит остаток от деления.
// Примеры
// 14 , 5 => нет 4
// 16, 8 => да 4
// 4, 3 => нет 1 

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

if(num1 % num2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine(" нет " + num1 % num2);
}

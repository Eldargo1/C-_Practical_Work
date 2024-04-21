// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int FirstEl = 0;
int ThirthEl = 0;
int result = 0;
 
if(num > 99)
{
    if(num < 1000)
    {
        FirstEl = num % 10;
        ThirthEl = num / 100;
        result = FirstEl + ThirthEl;
    }
}
Console.WriteLine(result);


// Это пример для тринеровки тут уже умножение первой и последней цифры трехзначной цифры.

// Console.WriteLine("Введите трехзначной число");
// int num = Convert.ToInt32(Console.ReadLine());

// int FEl = 0;
// int TEl = 0;
// int result = 0;

// if(num > 99)
// {
// if(num < 1000)
// {
//     FEl = num % 10;
//     TEl = num / 100;
//     result = FEl * TEl;
// }
// }
// Console.WriteLine(result);
// Напишите программу, которая принимает на вход 
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 456 => 8*7 = 2097152
// 254 => 5*4 = 625
// 617 => 1

int num = new Random().Next(100,1000);
Console.WriteLine(num);

int SEl= num % 100 / 10;
int TEl = num % 10;
int result = 1;

while(TEl > 0)
{
    result = result * SEl;
    TEl = TEl -1;
}
Console.WriteLine(result);
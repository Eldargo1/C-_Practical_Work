// Напишите программу, которая будет принимать на вход число и 
// возвращщать сумму его цифра.
// Использовать рекурсию.
// Пример
// 123 = > 6
// 69 = > 9

Console.WriteLine("Введите число");
int userNum = int.Parse(Console.ReadLine());

int result = SetSumNum(userNum);
Console.WriteLine(result);

int SetSumNum(int num)
{
    if(num<= 0)
    {
        return 0;
    }
    return num%10 + SetSumNum(num/10);
}
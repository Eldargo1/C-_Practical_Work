// Задатайте значение N. Напишите программу, которая выдает
// все натуральные числа в промежутке от 1 до N.
// Указание  
//Использовать рекурсию. Не использовать цикл.
// Пимер
// N = 5 => 1 2 3 4 5

Console.WriteLine("Введите число N");
int userNum = int.Parse(Console.ReadLine());

int firstEl = 1;
SetSumNum(firstEl, userNum);

void SetSumNum(int start, int end)
{
    if(start > end)
    {
        return;
    }

    Console.Write(start+ " ");
    start++;
    SetSumNum(start, end);
}

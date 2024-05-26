// Считаать сторку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой сторки.
// Указание
// Тспользовать ркекурсию. Не использовать цикл.
//Пример
//"Hello" => h l l
// "World" => w r l d
//"Hello world" => h l l w r l d

Console.WriteLine("Введите текст");
string userInput = Console.ReadLine();

int firstEl = 0;
string vowels = "aeiouy";
SetSumNum(firstEl);

void SetSumNum(int start)
{
    if(start >= userInput.Length)
    {
        return;
    }
    if(!vowels.Contains(userInput[start]))
    {
        Console.Write(userInput[start]);
    }
    start++;
    SetSumNum(start);
}

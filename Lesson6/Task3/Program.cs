// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

Console.WriteLine("Введите строчку");
string UserInput = Console.ReadLine();

string vowels = "aeiouy";
int count = 0;
for (int i = 0; i < UserInput.Length; i++)
{
    if(vowels.Contains(UserInput[i]))
    {
        count++;
    }
}
Console.Write(count);

// А если нужно проверить не на содержание гласных 
// а на не содержание пишется тот же код но добавляется знак -!

// Console.WriteLine("Введите строчку");
// string UserInput = Console.ReadLine();

// string vowels = "aeiouy";
// int count = 0;
// for (int i = 0; i < UserInput.Length; i++)
// {
//     if(!vowels.Contains(UserInput[i])) вот тут 
//     {
//         count++;
//     }
// }
// Console.Write(count);
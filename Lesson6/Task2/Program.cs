﻿// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран

System.Console.WriteLine("Введите строчку");
string userInput = Console.ReadLine();

char[] array = new char[userInput.Length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = userInput[i];
    Console.Write(array[i]+ " ");
}




// int i = 0;
// foreach (var item in userInput)
// {
//     array[i] = item;
//     i ++;
    
// }
// Console.Write(array[i]+ " ");
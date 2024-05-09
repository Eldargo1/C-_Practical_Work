// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива. 

char [] array = new char[]{'t', '7', ';', 'p'};
string str = "";

// for (int i = 0; i < array.Length; i++)
// {
//     str = str + array[i];
// }

foreach (var item in array)
{
    str = str + item;
}
Console.WriteLine(str);
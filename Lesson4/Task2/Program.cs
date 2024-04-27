// Задайте массив из N случайных чисел 
// (N вводится с клавиатуры.) 
// найдите количество чиселб которые 
// оканчиваются на 1 и делятся нацело на 7.
// Пример 
// [1 5 11 21 81 4 0 91 2 3] => 2      

// Console.WriteLine("Введите число"); 
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// void FillArray()
// {
//     for (int i = 0; i < array.length; i++)
//     {
//         array[i] = new Random().Next(20,25);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
// }

// int GetNumInArray()
// {
//     int count = 0;
//     for (int i = 0; i < array.length; i++)
//     {
//         if(array[i] % 7 == 0 && array[i] % 10 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// FillArray();
// PrintArray();
// Console.WriteLine(GetNumInArray+ " ");


Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(20,25);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

int GetNumInArray()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 7 == 0 && array[i] % 10 == 1)
        {
          count++;
        }
    }
    return count;
    
}

FillArray();
PrintArray();
Console.WriteLine("кол. = " +GetNumInArray());
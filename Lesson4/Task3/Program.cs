// Заполните массив на N (вводится с консоли, не боее 8 )
// случайных целых чисел.
// сформируйте целое число, которе будет состоять из цифр из 
// массива. Старший разряд числа находятся на 0-м индексе 
// младший на коследнем.

Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
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
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
       result = result + array[i];
    }
    return int.Parse(result);
    
}

FillArray();
PrintArray();
Console.WriteLine("кол. = " +GetNumInArray());
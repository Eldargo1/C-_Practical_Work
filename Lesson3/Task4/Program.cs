// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

for(int i = 0; i < array.Length; i++, num/=10)
{
    array[i] = num % 10;
    Console.Write(array[i]);
    // num = num / 10; // для того что бы цифра менялась а точнее что бы удалять последнюю цифру
}

// ля работы в массиве с не целыми числами
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[3];

// for(int i = 0; i < array.Length; i++, num/=10)
// {
//     array[i] = new Random().NextDouble();// для того что бы было не толькко не целочисленные цифры с 0 а также пример 2.05 , 3.05 
//     array[i] = num % 10;
//     Console.Write(array[i]);
    // num = num / 10; // для того что бы цифра менялась а точнее что бы удалять последнюю цифру
// }
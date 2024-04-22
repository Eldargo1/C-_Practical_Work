// // Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет
 
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int res = 0;
if( num > 100)
{
    res = num /100 % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}




 // тут код выводит третью с начала заданного числа.
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
// int res = 0;
// if( num > 100)
// {
//     while(num > 1000)
//     {
//         num = num / 10; // для отсечение последней цифры
//     }
//     res = num % 10;
//     Console.WriteLine(res);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }


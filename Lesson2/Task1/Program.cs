// Напишите пргорамму, которая принимает 
// на вход трёхзначное число и удаляет
// вторую цифру этого числа.
// a = 256 => 26
// b = 891 => 81

// int num = new Random().Next(100,1000);
// Console.WriteLine(num); // вышло число 256

// int FEl = num / 100; // 2
// int TEl = num % 10; // 6 
// int result = FEl *10 + TEl; // первый элмент умножаем на 10 и добавляем 2-ой элемент. 2*10+6=26

// Console.WriteLine(result);

// 2 ой вариант в котором можно не задавать много переменных
int num = new Random().Next(100,1000);
Console.WriteLine(num); 

int result = num / 100*10 + num % 10; 

Console.WriteLine(result);


//3 и вариант можно вообще без переменных
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// Console.WriteLine(num / 100 * 10 + num % 10);


// Это не задание это я сделал сам
// Console.WriteLine("Ваедите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int FEl = num / 100;
// int TEl = num % 10;

    
// Console.WriteLine(FEl+ " и " +TEl);





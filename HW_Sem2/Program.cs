// // Task1

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// // "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
// if (number % 7 == 0 && number % 23 == 0)
// {
//         Console.WriteLine($"Число: {number} кратно и 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число: {number} не кратно и 7 и 23");
// }   

// // Task2 

// Console.Write("Введите координату Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// // "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// // "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
// if ( x > 0 && y > 0)
// {
//         Console.WriteLine($"Точка расположена в 1 координатной четверти");
// }
// if ( x > 0 && y < 0)
// {
//     Console.WriteLine($"Точка расположена в 4 координатной четверти");
// }   
// if ( x < 0 && y < 0)
// {
//     Console.WriteLine($"Точка расположена в 3 координатной четверти");
// }   
// if ( x > 0 && y > 0)
// {
//     Console.WriteLine($"Точка расположена в 2 координатной четверти");
// }   
// if ( x != 0 && y == 0)
// {
//     Console.WriteLine($"Точка расположена на оси X");
// }   
// if ( x == 0 && y != 0)
// {
//     Console.WriteLine($"Точка расположена на оси Y");
// }   
// if ( x == 0 && y == 0)
// {
//     Console.WriteLine($"Точка расположена в центре координат");
// }   

// // Task3

// Console.Write("Введите двузначное число в промежутке между 10 и 99: ");

// int number = Convert.ToInt32(Console.ReadLine());

// // "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// // "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)

// while (number < 10 || number > 99)
// {
//     Console.WriteLine($"Пожалуйста введите корректное значение");
//     number = Convert.ToInt32(Console.ReadLine());
// }
// if (number >= 10 && number <= 99)
// {
//     int firstDigit = number / 10; // 275 / 100 = 2
//     int secondDigit = number % 10; // 275 % 10 = 5
//     if (firstDigit >= secondDigit)
//     {
//         Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
//     }
//     else
//     {
//         Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");
//     }

// }

// // Task4

// Console.Write("Введите число: ");
// long number = (long)Convert.ToInt64(Console.ReadLine());
// int i = 18; // Максимальный размер типа Long - 1
// long number2 = 0;
// while (number > 0)
// {
//     number2 = (number % 10) * (long)Math.Pow(10, i) + number2;
//     i--;
//     number = number / 10;
// }
// if (number2 % 10 == 0)      // Если число короткое, то стираем нули после разворота числа.
//     while (number2 % 10 == 0)
//     {
//         number2 = (number2 / 10);
//     }
// i = 0;
// while (number2 > 0)
// {
//     number = (number2 % 10);
//     i++;
//     number2 = number2 / 10;
//     if (number2 > 0)
//     {
//         Console.Write($"{number}, ");
//     }
//     else
//     {
//         Console.Write($"{number}");
//     }
// }

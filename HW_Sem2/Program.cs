Console.Write("Введите двузначное число в промежутке между 10 и 99: ");

int number = Convert.ToInt32(Console.ReadLine());

// "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)

while (number < 10 || number > 99)
{
    Console.WriteLine($"Пожалуйста введите корректное значение");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number >= 10 && number <= 99)
{
    int firstDigit = number / 10; // 275 / 100 = 2
    int secondDigit = number % 10; // 275 % 10 = 5
    if (firstDigit >= secondDigit)
    {
        Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
    }
    else
    {
        Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");
    }

}

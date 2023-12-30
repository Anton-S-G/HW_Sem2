Console.Write("Введите число: ");
long number = (long)Convert.ToInt64(Console.ReadLine());
int i = 18; // Максимальный размер типа Long - 1
long number2 = 0;
while (number > 0)
{
    number2 = (number % 10) * (long)Math.Pow(10, i) + number2;
    i -- ;
    number = number / 10;
}
if (number2 % 10 == 0)      // Если число короткое, то стираем нули после разворота числа.
while (number2 % 10 == 0)
{
    number2 = (number2 / 10) ;
}
i = 0;  
while (number2 > 0)
{
    number = (number2 % 10); 
    i ++ ;
    number2 = number2 / 10;
    if (number2 > 0)
    {
     Console.Write($"{number}, ");
    }
    else {
     Console.Write($"{number}");
    }
}

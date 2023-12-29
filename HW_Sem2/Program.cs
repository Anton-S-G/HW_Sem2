Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
// "&&" = "И": апельсины И яблоки (покупаем и то, и другое)
// "||" = "ИЛИ": апельсины ИЛИ яблоки(что-то одно, либо все вместе)
if ( x > 0 && y > 0)
{
        Console.WriteLine($"Точка расположена в 1 координатной четверти");
}
if ( x > 0 && y < 0)
{
    Console.WriteLine($"Точка расположена в 4 координатной четверти");
}   
if ( x < 0 && y < 0)
{
    Console.WriteLine($"Точка расположена в 3 координатной четверти");
}   
if ( x > 0 && y > 0)
{
    Console.WriteLine($"Точка расположена в 2 координатной четверти");
}   
if ( x != 0 && y == 0)
{
    Console.WriteLine($"Точка расположена на оси X");
}   
if ( x == 0 && y != 0)
{
    Console.WriteLine($"Точка расположена на оси Y");
}   
if ( x == 0 && y == 0)
{
    Console.WriteLine($"Точка расположена в центре координат");
}   
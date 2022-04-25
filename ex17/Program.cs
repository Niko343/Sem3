Console.WriteLine("Введите координату X: ");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.WriteLine("Координаты не соответствуют конкретной четверти");
}
else if (X > 0 && Y > 0)
{
    Console.WriteLine("Координаты принадлежат 1 четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Координаты принадлежат 2 четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Координаты принадлежат 3 четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Координаты принадлежат 4 четверти");
}
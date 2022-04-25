Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("Координата X > 0, координата y > 0");
}
else if (num == 2)
{
    Console.WriteLine("Координата X < 0, координата y > 0");
}
else if (num == 3)
{
    Console.WriteLine("Координата X < 0, координата y < 0");
}
else if (num == 4)
{
    Console.WriteLine("Координата X > 0, координата y < 0");
}
else
{
    Console.WriteLine("Нет такой четверти");
}

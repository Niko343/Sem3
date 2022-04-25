// Программа принимает на вход координаты двух точен и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите первую координату X: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату Y: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату Z: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату X: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату Y: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату Z: ");
int z2 = int.Parse(Console.ReadLine());

double a = Math.Pow(x2 - x1, 2);
double b = Math.Pow(y2 - y1, 2);
double c = Math.Pow(z2 - z1, 2);
double S = Math.Round(Math.Sqrt(a + b + c), 2);
Console.Write("Расстояние между точками = ");
Console.WriteLine(S);
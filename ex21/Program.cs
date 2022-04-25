Console.WriteLine("Введите первую координату X: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату Y: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату X: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату Y: ");
int y2 = int.Parse(Console.ReadLine());
double a = Math.Pow(x1 - x2, 2);
double b = Math.Pow(y1 - y2, 2);
double c = a + b;
double S = Math.Round(Math.Sqrt(c), 2);
Console.Write("Расстояние между точками = ");
Console.WriteLine(S);



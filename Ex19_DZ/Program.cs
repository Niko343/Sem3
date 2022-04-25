// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
int x1 = a % 10;
int x2 = a / 10 % 10;
int x3 = a / 100 % 10;
int x4 = a / 1000 % 10;
int x5 = a / 10000 % 10;
if (x1 == x5 & x2 == x4)
{
    Console.WriteLine($"Число {a} является палиндромом");
}
else 
{
    Console.WriteLine($"Число {a} не является палиндромом");
}
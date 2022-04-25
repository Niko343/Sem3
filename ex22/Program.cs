Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int index = 0;
while (index <= N)
{
    Console.Write(Math.Pow(index, 2));
    Console.Write(", ");
    index++;   
}
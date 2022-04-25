Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int index = 1;
while (index <= N)
{
    Console.Write(Math.Pow(index, 3));
    Console.Write(", ");
    index++;   
}

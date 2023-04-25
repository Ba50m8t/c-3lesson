Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до {N}:");
for (int i = 1; i <= n; i++) 
    {
    Console.WriteLine("{0}^3 = {1}", i, i*i*i);
    }
// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число, которое будем возводить в степень => ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число-показатель степени => ");
int b = int.Parse(Console.ReadLine());

int d = Pow(a, b);

int Pow(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine($" Число {a} в степени {b} равняется: {d}");
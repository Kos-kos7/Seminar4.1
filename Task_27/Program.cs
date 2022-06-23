// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write($"Введите число, а я найду сумму цифр в числе => ");
int number = int.Parse(Console.ReadLine());

int sum = Sum(number);
int Sum(int number)
{
    int countnum = number;
    int secnum = 0;
    int result = 0;
    while (countnum != 0)
    {
        secnum = countnum % 10;
        result = result + secnum;
        countnum = countnum / 10;
    }
    return result;
}

Console.Write($"Сумма цифр в числе {number} будет: {sum}");

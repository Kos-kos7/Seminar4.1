// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите целое число => ");
int number = int.Parse(Console.ReadLine());

int quantityOfDigits = Count(number);

Console.WriteLine($"Количество цифр в числе {number} => {quantityOfDigits}");

int Count(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
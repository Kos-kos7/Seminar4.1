// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите целое число N => ");
int number = int.Parse(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine($"Сумма чисел от 1 до N: {sum}");

int Sum(int number)
{
int result = 0;
for (int i = 1; i <= number; i++)
{
   result = result + i;
}
return result;
}

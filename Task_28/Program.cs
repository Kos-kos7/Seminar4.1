// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое число => ");
int number = int.Parse(Console.ReadLine());

int multiplication = Multiplication(number);

Console.WriteLine($"Произведение чисел от 1 до {number} => {multiplication}");

int Multiplication(int number)
{
int mult = 1;
for (int i = 1; i <= number; i++)
{
    mult = mult * i;
}
return mult;
}
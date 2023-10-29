// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sum = 0;

SumNaturalNumbers(number1, number2);
Console.WriteLine($"{sum}");

void SumNaturalNumbers (int num1, int num2)
{
    int prom1 = num1 - 1;
    if(num2 == prom1) return;
    sum += num2;
    SumNaturalNumbers(num1, num2 - 1);
}
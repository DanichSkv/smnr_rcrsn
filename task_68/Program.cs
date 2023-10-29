// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Привет, я считаю функцию Аккермана A(m, n). Введите m= ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n= ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = AckermanFnctn(number1, number2);
Console.WriteLine(result);

int AckermanFnctn (int num1, int num2)
{
    if (num1 == 0) return num2 += 1;
    if ((num1 != 0) && (num2 == 0)) return AckermanFnctn(num1 - 1, 1);
    return AckermanFnctn(num1 - 1, AckermanFnctn(num1, num2 - 1));
}

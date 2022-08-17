// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum (int number)
{
    int lastNumber = number % 10;
    int result = 0;
    while (number / 10 > 0)
    {
        result = result + number / 10 % 10;
        number /= 10;
    }
    return result + lastNumber; 
}

Console.WriteLine("Введите число и нажмите Enter.");
int num = Convert.ToInt32(Console.ReadLine());

int res = Sum(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {res}.");
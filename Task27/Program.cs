// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum (int number)
{
    if (number < 0)
    {
        return -1;
    }
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
string res1 = res == -1 ? "введите число большее, либо равное нулю" : res.ToString();
Console.WriteLine($"Сумма цифр в числе {num} равна: {res1}.");
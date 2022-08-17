// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeofNumber (int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}
Console.WriteLine("Введите число А и нажмите Enter.");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B и нажмите Enter.");
int numB = Convert.ToInt32(Console.ReadLine());
int res = DegreeofNumber(numA, numB);
Console.WriteLine($"{numA} в степени {numB} = {res}");

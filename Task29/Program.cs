// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray (int[]collection)
{
    int lenght = collection.Length;
    int i = 0;
    Random rnd = new Random();
    while (i < lenght)
    {
        collection[i]=rnd.Next(-45926,12345);
        i++;
    }
}
void PrintArray (int[]col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[ ");
    while (position < count - 1)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write($"{col[position]} ]");
}
int[]array = new int [8];
FillArray(array);
PrintArray(array);
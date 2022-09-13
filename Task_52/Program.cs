// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int [,] array = new int[3,3];
for (int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < 3; i++) 
{
    int srAr = 0;

    for (int t = 0; t < 3; t++)
    {
        srAr += array[t, i];
    }
Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/3}");
}

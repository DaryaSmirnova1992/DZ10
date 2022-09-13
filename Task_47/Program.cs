// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] array = new double[rows,columns];

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        array[i,j] = new Random().Next(0,10)*100;
        Console.Write(Math.Round(array[i,j], 2)+ "\t");
    }
    Console.WriteLine();
}
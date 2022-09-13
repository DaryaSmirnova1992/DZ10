// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[rows,columns];

for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        
        array[i,j] = new Random().Next(10,100);
        Console.Write(array[i,j]+ "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите номер строки: ");
int numberRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());

if (rows < numberRows || columns < numberColumns)
{
    Console.Write("Такой позиции в массиве нет");
}
else
Console.WriteLine(array[numberRows-1, numberColumns-1]);
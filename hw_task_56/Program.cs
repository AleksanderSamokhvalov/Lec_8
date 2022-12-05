// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк матрицы");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы");
int columns = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int [rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] +   " ");
    }
    Console.WriteLine();
}

Console.WriteLine("================================");

int summ = 0;
int minSumm = int.MaxValue;
int minSummRow = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        summ +=matrix[i,j];
    }
        if (summ<minSumm)
        {
            minSumm=summ;
            minSummRow = i;
        }
        summ = 0;
}

Console.WriteLine("Минимальная сумма в строке = "  + minSumm);

Console.WriteLine("Индекс строки с минимальной суммой элементов =  "  + minSummRow);
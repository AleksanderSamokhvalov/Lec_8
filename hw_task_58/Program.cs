// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите количество строк матрицы 1");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы 1");
int columns1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите количество строк матрицы 2");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы 2");
int columns2 = Convert.ToInt32(Console.ReadLine());


// int [] average = new int [columns];

int [,] matrix1 = new int [rows1,columns1];
int [,] matrix2 = new int [rows2,columns2];

int [,] matrix_3 = new int [rows2,columns2];

if (rows1!=columns2)
{
    Console.WriteLine("Произведение данных матриц найти невозможно, число строк матрицы 1 должно равняться числу стобцов матрицы 2!");
}
else
{
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i,j] = new Random().Next(0,10);
        Console.Write(matrix1[i,j] +   " ");
    }
    Console.WriteLine();
}

Console.WriteLine("================================");

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j] = new Random().Next(0,10);
        Console.Write(matrix2[i,j] +   " ");
    }
    Console.WriteLine();
}
Console.WriteLine("================================");

Console.WriteLine("Произведение двух матриц");

// for (int i = 0; i < matrix_3.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix_3.GetLength(1); j++)
//     {
//         matrix_3[i,j] += matrix1[i,j]*matrix2[j,i];
//         // Console.Write(matrix_3[i,j] +   " ");
//     }
    
//     Console.WriteLine();
// }
 for (int i = 0; i < matrix_3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_3.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix_3.GetLength(0); k++)
                    {
                        matrix_3[i,j] += matrix1[i,k] * matrix2[k,j];
                        // Console.Write(matrix_3[i,j] +   " ");
                    }
                    Console.Write(matrix_3[i,j] +   " // ");
                 
                }
  Console.WriteLine(" ");
            }


}
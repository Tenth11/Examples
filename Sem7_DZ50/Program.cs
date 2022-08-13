// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine();
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine()) - 1;
int[,] matrix = new int[4, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i, j] = new Random().Next(-10,10);
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + " \t");
Console.WriteLine();
}
if(n >=0 && n < matrix.GetLength(0) && m >=0 && m < matrix.GetLength(1)){
Console.WriteLine("Элемент сущетсует: " + matrix[n,m]);
}
else
Console.WriteLine("Элемент не сущетсует");


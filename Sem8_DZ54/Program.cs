
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++){
array[i, j] = new Random().Next(0,10);
Console.Write(array[i, j] + " \t");
}
Console.WriteLine();
}
Console.WriteLine();

void SortArray(int[,] array){
for ( int i = 0; i < n; i++)
{
for ( int j = 0; j < m; j++)
{
for ( int k = 0; k < m-1; k++)
{
if ( array[i,k] < array[i,k+1] )
{
int temp = array[i,k + 1];
array[i,k+1] = array[i,k];
array[i,k] = temp;
}
}
}
}
}
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " \t");
    }
    Console.WriteLine();
  }
}
SortArray(array);
PrintArray(array);
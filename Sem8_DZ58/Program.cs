// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++){
array[i, j] = new Random().Next(0,10);
Console.Write(array[i, j] + " \t");
}
Console.WriteLine();
}
Console.WriteLine();

int[,] arraySecond = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++){
arraySecond[i, j] = new Random().Next(0,10);
Console.Write(arraySecond[i, j] + " \t");
}
Console.WriteLine();
}
Console.WriteLine();

int[,] arrayResult = new int[4, 4];

void WorkArray(int[,] array, int[,] arraySecond, int[,] arrayResult){
for (int i = 0; i < arrayResult.GetLength(0); i++)
  {
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
      int sum = 0;
      sum = array[i,j] * arraySecond[i,j];
      arrayResult[i,j] = sum;
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " \t");
    }
    Console.WriteLine();
  }
}
WorkArray(array,arraySecond,arrayResult);
WriteArray (arrayResult);


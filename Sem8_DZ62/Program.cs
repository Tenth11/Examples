﻿// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] array = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}
for (int k = 0; k < array.GetLength(0); k++)
  {
    for (int l = 0; l < array.GetLength(1); l++)
    {
      if (array[k,l] / 10 <= 0)
      Console.Write($" {array[k,l]} ");

      else Console.Write($"{array[k,l]} ");
    }
    Console.WriteLine();
  }


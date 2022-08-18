// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int SumLine(int [,] array, int i){
int sum = array[i,0]; 
for (int j = 1; j < m; j++)
sum += array[i,j];
return sum;
}


int minSum = 0;
int sumLine = SumLine(array, 0);
for (int i = 1; i < n; i++)
{
  int otherSumLine = SumLine(array, i);
  if (sumLine > otherSumLine)
  {
    sumLine = otherSumLine;
    minSum = i;
  }
}
Console.WriteLine("Номер строки с минимальной суммой: " + (minSum + 1));





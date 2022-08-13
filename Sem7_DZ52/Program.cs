// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[] s = new double[n];
int[,] matrix = new int[n, m];
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++){
matrix[i, j] = new Random().Next(0,10);
Console.Write(matrix[i, j] + " \t");
}
Console.WriteLine();
}
for (int i = 0; i < n; i++){
for (int j = 0; j < m; j++)
 s[i] = s[i] + matrix[j,i];
 Console.WriteLine(Math.Round(s[i]/n, 1));
}

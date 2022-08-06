// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int n = 10;
int[] array = new int[n];
int summ = 0;
for (int i = 0; i < n; i++)
{
array[i] = new Random().Next(0, 10);
if (i % 2 != 0)
summ = summ + array[i];
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(summ);

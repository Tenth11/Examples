// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int n = 10;
int[] array = new int[n];
int max = 0;
int min = 10;
int diff = 0;
for (int i = 0; i < n; i++)
{
array[i] = new Random().Next(0, 10);
if (array[i] > max)
max = array[i];
if (array[i] < min)
min = array[i];
diff = max - min;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(diff);
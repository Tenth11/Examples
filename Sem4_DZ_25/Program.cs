//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 0; i < b; i++){
 result *= a;
}
Console.WriteLine(result);

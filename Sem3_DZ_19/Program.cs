// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
if(Convert.ToString(a)[0] == Convert.ToString(a)[4] && Convert.ToString(a)[1] == Convert.ToString(a)[3])
  Console.WriteLine("Число " + a + " является полиндромом");
else 
  Console.WriteLine("Число " + a + " не является полиндромом");
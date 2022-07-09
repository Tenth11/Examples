int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if( a > b && a > c)
   Console.WriteLine("Максимальное число: " + a);
if (b > a && b > c) 
   Console.WriteLine("Максимальное число: " + b);
else  Console.WriteLine("Максимальное число: " + c);

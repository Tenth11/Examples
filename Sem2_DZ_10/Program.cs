int x = new Random().Next(10, 1000);
Console.WriteLine(x);
Console.WriteLine("Второе число: " + ((x % 100)/10));
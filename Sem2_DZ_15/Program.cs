int x = new Random().Next(1, 8);
Console.WriteLine(x);
if(x == 6 || x ==7)
  Console.WriteLine("Сегодня выходной день");
 else 
  Console.Write("Сегодня обычный день");

int x = new Random().Next(1, 100000);;
Console.WriteLine(x);
if(x < 100)
  Console.WriteLine("Третьей цифры нет");
 else 
  Console.Write("Третья цифра: " + Convert.ToString(x)[2]);
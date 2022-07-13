double x = 10;
int y = 20;
int day = 1;
while(y >= x)
{
  x = x *1.15;
  Console.WriteLine((int)x);
  day++;
}
Console.WriteLine("Через: " + day + " дней пробег спортсмена составит не менее " + y + " километров");

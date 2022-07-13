double x = 100;
int y = 200;
int year = 0;
while(y >= x)
{
  x = x *1.1;
  Console.WriteLine((int)x);
  year++;
}
Console.WriteLine("Через: " + year + " вклад составит не менее " + y + " рублей");
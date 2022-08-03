//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int a = Convert.ToInt32(Console.ReadLine());
int count =0;
int num = 0;
int res = 0;
while(a !=0){
    num = a % 10;
    a = a / 10;
    res = res + num;
    count++;
}
Console.WriteLine(res);

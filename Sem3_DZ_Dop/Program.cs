//Задана последовательность натуральных чисел, завершающаяся числом 0.
// Требуется определить значение второго по величине элемента в этой 
// последовательности, то есть элемента, который будет наибольшим,
// если из последовательности удалить наибольший элемент. 

int a = 2;
int b = 166;
int c = 21;
int d = 12;
int e = 0;

int max = a;
if(a > max) max = a ;
if(b > max) max = b ;
if(c > max) max = c ;
if(d > max) max = d ;
if(e > max) max = e ;

Console.Write("max = ");
Console.WriteLine(max);

int max2 = a;

if(a > max2 && a < max) max2 = a ;
if(b > max2 && b < max) max2 = b ;
if(c > max2 && c < max) max2 = c ;
if(d > max2 && d < max) max2 = d ;
if(e > max2 && e < max) max2 = e ;

Console.Write("max2 = ");
Console.WriteLine(max2);
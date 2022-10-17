/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{ 
    Console.Write("max = " + a);
}
else
{
    Console.Write("max = " + b);
}

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inpet a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if (n1 > max) max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.Write(max);

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());
int whole = n/2;
if (n%2==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Input a number ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= N) 
{
    if (current % 2==0)
    Console.Write(current + " ");
    current ++;
    
}

*/
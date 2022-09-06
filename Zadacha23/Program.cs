//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите положительное число");
start:
int N = int.Parse(Console.ReadLine());
if(N <1)
{
    Console.WriteLine("Положительное число. Введите ещё раз.");
    goto start;
}
int count = 1;
int fin = count;
Console.Write($"{N} -> ");
while(count < N)
{
    fin = count*count*count;
    Console.Write($"{fin},");
    count++;
}
if(count == N)
{
    fin = count*count*count;
    Console.Write($"{fin}");
}
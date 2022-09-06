// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

start:
Console.WriteLine("Введите пятизначное число");
int par = int.Parse(Console.ReadLine());

if(par<10000 || par >99999)
{
    Console.WriteLine("Пятизначное число пожалуйста.");
    goto start;
}
int a1 = par%10;
int a2 = par/10000;
int b1 = (par/10)%10;
int b2 = (par/1000)%10;

if(a1 == a2 && b1 == b2)
{
    Console.WriteLine($"{par} -> да");
}
else
{
    Console.WriteLine($"{par} -> нет");
}
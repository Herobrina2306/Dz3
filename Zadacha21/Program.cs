// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
string[] array1 = Console.ReadLine().Split(new char[] { ',' }); 
int x1 = int.Parse(array1[0]); 
int y1 = int.Parse(array1[1]);
int z1 = int.Parse(array1[2]);  
Console.WriteLine("Введите координаты второй точки"); 
string[] array2 = Console.ReadLine().Split(new char[] { ',' }); 
int x2 = int.Parse(array2[0]); 
int y2 = int.Parse(array2[1]);      
int z2 = int.Parse(array2[2]);

double fin = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);
Console.WriteLine($"Расстояние между двумя точками: {fin}");
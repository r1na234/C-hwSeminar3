//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

System.Console.WriteLine("enter x1: ");
double x1 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("enter x2: ");
double x2 = double.Parse(System.Console.ReadLine());

System.Console.WriteLine("enter y1: ");
double y1 = double.Parse(System.Console.ReadLine());

System.Console.WriteLine("enter y2: ");
double y2 = double.Parse(System.Console.ReadLine());

System.Console.WriteLine("enter z1: ");
double z1 = double.Parse(System.Console.ReadLine());

System.Console.WriteLine("enter z2: ");
double z2 = double.Parse(System.Console.ReadLine());

double distance = Math.Sqrt((Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2))+ (Math.Pow((z2-z1),2)));
System.Console.WriteLine(Math.Round(distance,2));
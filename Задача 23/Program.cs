//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27

System.Console.Write("Enter the number:  ");
int number = int.Parse(System.Console.ReadLine());
System.Console.WriteLine($"куб чисел от 1 до {number} равен: ");

for(double i = 1; i <= number; i++){
    double sqr = Math.Pow(i, 3);
    System.Console.WriteLine(sqr);
}

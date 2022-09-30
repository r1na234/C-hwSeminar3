// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

System.Console.WriteLine("Enter the number");
int number = int.Parse(Console.ReadLine());

if(((number % 7) == 0) && ((number % 23) == 0)){
        System.Console.WriteLine("кратно 7 и 23");
}
else{
    System.Console.WriteLine("не кратно");
}
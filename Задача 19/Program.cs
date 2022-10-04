//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет

System.Console.WriteLine("Enter a number:   ");
int number = int.Parse(System.Console.ReadLine());

string numberstring = number.ToString();
char[] reversenumber = numberstring.ToCharArray();
Array.Reverse(reversenumber);
int number2 = int.Parse(reversenumber);

if(number2 == number){
    System.Console.WriteLine("является");
}
else{
    System.Console.WriteLine("не является");
}
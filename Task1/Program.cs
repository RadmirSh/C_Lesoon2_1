// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt (string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Write three-digit number");
if (number >=100 && number <1000)
{
int mid = number/ 10 % 10;
System.Console.WriteLine( $"Second count of {number} is {mid}");
}
else
System.Console.WriteLine("It is not three-digit number");
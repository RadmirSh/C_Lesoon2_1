// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Write number please");
string ss = "It is not day of week";
string check(int number)
{
if (number >= 6 && number < 8) ss = "It is Day off";
if (number >= 1 && number < 7) ss = "It is Weekday";
return ss;
}
System.Console.WriteLine(check(number));
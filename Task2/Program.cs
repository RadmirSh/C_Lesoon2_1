// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Write number, please");

int fnumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}

if (check(number) != true)
System.Console.WriteLine("The third count is not exist");
else
System.Console.WriteLine($"The third count of {number} is {fnumber(number)}");
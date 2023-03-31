// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Input a number: ");
string value;
value = Console.ReadLine();
int number = Convert.ToInt32(value);

int result = number % 2;

if(result == 0)
{
    System.Console.WriteLine(number + " is even number.");
}
else
{
    System.Console.WriteLine(number + " is not even number.");
}
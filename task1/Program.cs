// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое 
// число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3, min = -9

System.Console.Write("Input 1st number: ");
string value1;
value1 = Console.ReadLine();
int number1 = Convert.ToInt32(value1);

System.Console.Write("Input 2nd number: ");
string value2;
value2 = Console.ReadLine();
int number2 = Convert.ToInt32(value2);

if(number1 > number2)
{
    System.Console.WriteLine($"{number1} is max number, {number2} is min number.");
}
else
{
    System.Console.WriteLine($"{number2} is max number, {number1} is min number.");
}
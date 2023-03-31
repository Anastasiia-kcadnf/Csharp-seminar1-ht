// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Input 1st number: ");
string value1;
value1 = Console.ReadLine();
int number1 = Convert.ToInt32(value1);

System.Console.Write("Input 2nd number: ");
string value2;
value2 = Console.ReadLine();
int number2 = Convert.ToInt32(value2);

System.Console.Write("Input 3rd number: ");
string value3;
value3 = Console.ReadLine();
int number3 = Convert.ToInt32(value3);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

System.Console.WriteLine(max + " is max number.");
// Задача, оставшаяся с семинара:
// * Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7

System.Console.Write("Input a number: ");
string value;
value = Console.ReadLine();
int number = Convert.ToInt32(value);

int numAbs = System.Math.Abs(number);

System.Console.Write($"Absolute value of {number} is {numAbs}.");
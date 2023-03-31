// Задача, оставшаяся с семинара:
// ** Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.
// 1 -> 1
// 2 -> 0.5
// 0.25 -> 4

System.Console.Write("Input a number: ");
string value;
value = Console.ReadLine();
double number = Convert.ToDouble(value);

double inversedNum = 1 / number;

System.Console.Write($"Inversed number of {number} is {inversedNum}.");
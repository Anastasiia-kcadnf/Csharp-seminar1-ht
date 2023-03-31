// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Input a number: ");
string value;
value = Console.ReadLine();
int number = Convert.ToInt32(value);

int numAbs = System.Math.Abs(number);

int current = 2;

if(numAbs < 2)
{
    System.Console.Write($"There is no even numbers from 1 to {numAbs}");
}
else
{
    while(current <= numAbs)
    {
        System.Console.Write(current + " ");
        current += 2;
    }
}

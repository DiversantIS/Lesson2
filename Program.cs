/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int GetNumber ()
{
Console.WriteLine("Введите число");
    string firstNumberStr = Console.ReadLine();
    int firstNumber =  Convert.ToInt32(firstNumberStr);
    return firstNumber;
} 
int firstNumber = GetNumber();

string str = firstNumber.ToString();
Console.WriteLine(str[1]);
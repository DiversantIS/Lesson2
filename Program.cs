/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите числовой день недели: ");
int memNumber = Convert.ToInt32(Console.ReadLine());

void TheEmtyDay (int memNumber) {
  if (memNumber == 6 || memNumber == 7) {
  Console.WriteLine("Этот день выходной))) да вы угадали");
  }
  else if (memNumber < 1 || memNumber > 7) {
    Console.WriteLine("введите число от 1 до 7");
  }
  else Console.WriteLine("Это не выходной день!!");
}

TheEmtyDay(memNumber);

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);
if (nText.Length > 2)
{
  Console.WriteLine("тут третья цифра " + nText[2]);
}
else 
{
  Console.WriteLine("тут третьей цифры нет");
}
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите цифру, обозначающую день недели: ");
int dayN = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayN) 
{
  if (dayN == 6 || dayN == 7) 
  {
  Console.WriteLine("еееее! Это выходной!");
  }
  else if (dayN < 1 || dayN > 7) 
  {
    Console.WriteLine("я знаю только СЕМЬ дней недели! (1-7)");
  }
  else Console.WriteLine("иди на работу... Это не выходной день недели :(");
}
CheckingTheDayOfTheWeek(dayN);


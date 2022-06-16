/*
// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.


Console.Write("Введите число: ");
string num = Console.ReadLine();

void CheckingNumber(string num)
{
  if (num[0]==num[4] && num[1]==num[3])
  {
    Console.WriteLine($"Число: {num} - является палиндромом.");
  }
  else Console.WriteLine($"Число: {num} - НЕ является палиндромом.");
}
if (num.Length == 5)
{
  CheckingNumber(num);
}
else Console.WriteLine($"Введите пятизначное число");
*/

/*
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.


int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string NameOfСoordinate, string NameOfPoint)
{
    Console.Write($"Введите координату {NameOfСoordinate} точки {NameOfPoint}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) + 
    Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double lengthofsegment =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние между ними в 3D пространстве = {lengthofsegment}");
*/


// Задача 23: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cub(int[] N)
{
  int count = 0;
  int length = N.Length;
  while (count <  length)
  {
    N[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void PrintArray(int[] mass)
{
  int count = mass.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(mass[index]+ " ");
    index++;
  }
} 
int[] array = new int[N+1];
Cub(array);
PrintArray(array);
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X не равно 0 и Y не
// равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
Console.WriteLine("Введите координаты точки X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y");
int y = Convert.ToInt32(Console.ReadLine());
if (x != 0 && y != 0)
{
  if (x > 0 && y > 0)
  {
    Console.WriteLine("Номер четверти на плоскости -> 1");
  }
  else if (x < 0 && y > 0)
  {
    Console.WriteLine("Номер четверти на плоскости -> 2");
  }
  else if (x < 0 && y < 0)
  {
    Console.WriteLine("Номер четверти на плоскости -> 3");
  }
  else
  {
    Console.WriteLine("Номер четверти на плоскости -> 4");
  }
}
else
  {
    Console.WriteLine("Ноль вводить нельзя, введите дугое число кроме нуля");
  }
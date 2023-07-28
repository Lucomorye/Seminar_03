// Напишите программу, которая по заданному номеру четверти,показывает диапазон возможных координат точек,
// в этой четверти (X и Y)
Console.Clear();
Console.WriteLine("Задайте номер четверти");
int num = Convert.ToInt32(Console.ReadLine());
int x = new Random().Next(0,100);
int y = new Random().Next(0,100);

if ( num == 1)
{
  Console.WriteLine($"{x},{y}");
}
else if ( num == 2)
{
  Console.WriteLine($"{-x},{y}");
}
else if ( num == 3)
{
  Console.WriteLine($"{-x},{-y}");
}
else 
{
  Console.WriteLine($"{x},{-y}");
}

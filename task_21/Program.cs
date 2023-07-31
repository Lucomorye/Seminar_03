// Напишите программу которая принимает на вход координаты двух точек, и находит расстояние между ними 
// в 2D пространстве
Console.Clear();
Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

// √((x2 - x1)^2 + (y2 - y1)^2);

double degX = Math.Pow((x2 - x1),2);
double degY = Math.Pow((y2 -y1), 2);
double sum = degX + degY;
double result = Math.Sqrt(sum);
result = Math.Round(result,3);

Console.WriteLine(result);
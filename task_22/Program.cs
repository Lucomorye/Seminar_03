// Напишите программу которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 да N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4
Console.Clear();
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= N; i++)
{
  Console.WriteLine(Math.Pow(i,2));
}

// while(i <= N)
// {
//   result = i * i;
//   Console.WriteLine(result);
//   i ++;
// }

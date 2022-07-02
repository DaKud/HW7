// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void Print (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
      Console.WriteLine();
  }
}

void Fill(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = Math.Round(new Random().Next(-2,5) + new Random().NextDouble(),2);
    }
  }
}

Console.Write("Insert 1st element:");
int n = int.Parse(Console.ReadLine()); 
Console.Write("Insert 2nd element:");
int m = int.Parse(Console.ReadLine()); 
double[,] mass = new double[m, n];

Fill(mass);
Print(mass);


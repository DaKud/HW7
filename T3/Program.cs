// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


void Print (int[,] array)
{
for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      Console.Write(array[i,j] + " ");
    }
      Console.WriteLine();
  }
}

void Fill(int[,] array)
{
  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(0); j++)
    {
      array[i,j] = new Random().Next(1,5);
    }
  }
}

Console.Write("Insert 1st element:");
int n = int.Parse(Console.ReadLine()); 
Console.Write("Insert 2nd element:");
int m = int.Parse(Console.ReadLine()); 
int[,] mass = new int[m, n];

Fill(mass);
Print(mass);

 
// for (int i = 0; i < m; i++) 
// {
//     int scalarsum = 0;
    
//     for (int j = 0; j < n; j++)
//     {
//         scalarsum += mass[j, i];
        
//     }
//     Console.WriteLine($"Cреднее арифметическое элементов столбца {i+1} = {(float)scalarsum/n+m}");
    
//     }



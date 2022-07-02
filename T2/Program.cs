// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
double PrintElement(double[,] array,int idx0,int idx1)
{
  double elem;
  if (array.GetLength(0)-1>idx0 && array.GetLength(1)-1>idx1)
  {
  
    return elem = array[idx0,idx1];
  }
  else
  {
    return elem = -100500;
  }
}

Console.Write("Insert 1st element:");
int n = int.Parse(Console.ReadLine()); 
Console.Write("Insert 2nd element:");
int m = int.Parse(Console.ReadLine()); 
double[,] mass = new double[m, n];

Fill(mass);
Print(mass);

Console.Write("Insert 1st element index:");
int idx0 = int.Parse(Console.ReadLine()); 
Console.Write("Insert 2nd element index:");
int idx1 = int.Parse(Console.ReadLine()); 
double elem = PrintElement(mass,idx0,idx1);
if (elem !=-100500 )
{
    Console.Write($"Massive element =  {elem}.");
}
else 
{
    Console.Write($"Massive element is NOT EXISTING");
}




PrintElement(mass,idx0,idx1);

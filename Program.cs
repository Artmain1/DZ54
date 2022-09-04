// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Введи число");
int a = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Введи число");
int b = Convert.ToInt32(Console.ReadLine());;
int[,] numbers = new int[a, b];
int m = 0;
int n = 0;
ArrayDouble(numbers);
WriteArray(numbers);

void ArrayDouble(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}
void WriteArray (int[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        int Number = array[i, j];
        Console.Write(Number + "\t");
      }
      Console.WriteLine();
  }
}
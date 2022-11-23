// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,]CreateRandom2Array(int rows, int columns, int minValue, int maxValue )
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue + 1);
             
        return array;
}
void Show2Array(int [,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
        int[,] SortUbiv(int[,] array)
        {
            int minVal = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1)-1; j++)
                {
                for (int k = 0; k < array.GetLength(1) - j-1; k++)
                    {
                   
                        if (array[i, k] < array[i, k+1])
                            {
                                minVal = array[i, k];
                                array[i, k] = array[i, k+1];
                                array[i, k+1] = minVal;
                            }
 
                    
                    }
 
                }
            }
            return array;
            
        }
        
Console.Write("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2Array(m, n, min, max);
Show2Array (myArray);
Console.WriteLine();
Show2Array(SortUbiv(myArray));

*/
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,]CreateRandom2Array(int rows, int columns, int minValue, int maxValue )
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue + 1);
             
        return array;
}
void Show2Array(int [,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }

}
int SumElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

Console.Write("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2Array(m, n, min, max);
Show2Array (myArray);
Console.WriteLine();

 int minSumLine = 0;
    int sumLine = SumElements(myArray, 0);
    for (int i = 1; i < myArray.GetLength(0); i++)
    {
        int tempSumLine = SumElements(myArray, i);
        if (sumLine > tempSumLine)
            {
            sumLine = tempSumLine;
            minSumLine = i;
            }
    }
Console.WriteLine($"\n{minSumLine} - строкa с наименьшей суммой ({sumLine}) элементов ");

*/
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

 int[,]CreateRandom2Array(int rows, int columns, int minValue, int maxValue )
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
         for(int j = 0; j < columns; j++)
        
            array[i,j] = new Random().Next(minValue, maxValue + 1);
             
        return array;
}
void Show2Array(int [,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] array1, int[,] array2, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}


Console.Write("Input a number of rows:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int max1 = Convert.ToInt32(Console.ReadLine());
int[,] myArray1 = CreateRandom2Array(m1, n1, min1, max1);
Show2Array (myArray1);
Console.Write("Input a number of rows:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] myArray2 = CreateRandom2Array(m2, n2, min2, max2);
int[,] resultArray = new int[m1,n2];


Show2Array (myArray2);
MultiplyMatrix(myArray1, myArray2, resultArray);
Console.WriteLine($"Произведение первой и второй матриц:");
Show2Array (resultArray);
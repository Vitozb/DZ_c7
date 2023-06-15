void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}

void SrAr(int[,] array)
{
    int count=0;
    Double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
        for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i,j];
                count++;
            }
            sum = Math.Round(sum/count,1);

            if (j == 0) 
            Console.Write($"Среднее арифметическое каждого столбца: {sum}; ");
            else Console.Write($"{sum}; ");
            sum = 0;
        }
        
        
        Console.WriteLine();
}


System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
SrAr(array);
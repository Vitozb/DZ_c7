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

void Number(int[,] array,int n)
{
    int count=0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j]==n) count++;
            }
        }
        if (count>0) Console.Write($"Число {n} встречается {count} раз");
        else Console.Write($"Число {n} не встречается в массиве");
        Console.WriteLine();
}


System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите искомое значение");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
Number(array,n);
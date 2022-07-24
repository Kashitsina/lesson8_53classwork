void Zadacha53()
{
    //задайте двумерный массив.Напишите программу ,которая поменяет местами первую и последнюю строку массива.

    Random random = new Random();
    int rows = random.Next(3, 8);
    int columns = random.Next(3, 8);

    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("вывод массива");
    PrintArray(array);
    Console.WriteLine("вывод массива 2");
    ChangeRows(array);
    PrintArray(array);
    void FillArray(int[,] array)
    {
    Random random = new Random();
    int rows = array.GetLength(0);
    int сolumns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
     {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-100, 100);
        }
     }
    }

    void PrintArray(int[,] array)
    {
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int сolumns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
        {
           for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
        }
        Console.WriteLine();

    }
    
    void ChangeRows(int[,] array)
    {
        int lastrow = array.GetLength(0) - 1;
        int rows = array.GetLength(1);
        for (int i = 0; i < rows ; i++)
        {
            (array [0, i], array[lastrow, i]) = (array[lastrow, i], array[0, i]);
        }
    }
}     
Zadacha53();         
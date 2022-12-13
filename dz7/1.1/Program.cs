void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j], 6} ");
        }
        Console.WriteLine();
    }

}

double[,] MassNums(int s1, int s2, int from, int to)
{
    double[,] arr = new double[s1, s2];
    Random n_new = new Random();
    for (int i = 0; i < s1; i++)
    {
        for (int j = 0; j < s2; j++)
        {
            arr[i, j] = Math.Round(n_new.NextDouble() * (from + to) - from,2);
        }
    }
    return arr;
}

double[,] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
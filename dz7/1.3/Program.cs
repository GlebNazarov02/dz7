void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j],6} ");
        }
        Console.WriteLine();
    }

}

double[,] MassNums(int s1, int s2, int from, int to)
{
    double[,] arr = new double[s1, s2];
    for (int i = 0; i < s1; i++)
    {
        for (int j = 0; j < s2; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}
void Arifm(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double sredn = 0;
    for (int j = 0; j < column; j++)
    {
        for (int i = 0; i < row; i++)
        {
            sredn = sredn + arr[i, j];
        }
        sredn = Math.Round((sredn/row),2);
        Console.Write($"{sredn}  ");
        sredn = 0;
    }

}

double[,] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Arifm(arr_1);
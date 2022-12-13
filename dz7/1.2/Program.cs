void Print(int[,] arr)
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

int[,] MassNums(int s1, int s2, int from, int to)
{
    int[,] arr = new int[s1, s2];
    for (int i = 0; i < s1; i++)
    {
        for (int j = 0; j < s2; j++)
        {
            arr[i, j] = new Random().Next(from,to);
        }
    }
    return arr;
}

void Poisk(int[,] arr, int stroka,int stolbec)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if ((stroka < row+1) & (stolbec < column+1) & (stroka > 0) & (stolbec > 0))
    {
        Console.WriteLine($"{arr[stroka-1,stolbec-1]}");
    }
    else Console.WriteLine("Такой позиции нет");
}

int[,] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine("Строка");
int storch = int.Parse(Console.ReadLine());
Console.WriteLine("Столбец");
int stlb = int.Parse(Console.ReadLine());
Poisk(arr_1,storch,stlb);
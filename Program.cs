using System;

public class Program
{
    static void Main(string[] args)
    {
        var x = GetPasVal(70, 65);
        Console.WriteLine(x);
        Console.ReadKey();
    }

    public static long GetPasVal(int height, int width)
    {
        long[,] triangle = new long[height + 1,width + 1];
        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= width; j++)
            {
                if (i == j)
                    triangle[i, j] = 1;
                if (j == 0 && i > 0)
                    triangle[i, j] = i;
                if (i > j && j > 0 && i > 0)
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
            }
        }
        return triangle[height, width];
    }
}

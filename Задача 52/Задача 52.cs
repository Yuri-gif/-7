Random random  = new Random ();
double  sum=0;
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j ++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");

for (int j = 0; j < arr.GetLength(1); j ++)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum  += arr [i, j];
    }
    double average = sum / arr.GetLength(0);
    int n = j + 1;
    Console.WriteLine("{0: 0.000}"+ average);
}

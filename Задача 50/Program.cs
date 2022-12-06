Console.WriteLine("Введите номер строки");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int st=Convert.ToInt32(Console.ReadLine());
int n = 4;
int m = 4;
int [,] numbers  = new int [n, m];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if(num<numbers.GetLength(0)&& st<numbers.GetLength(0))
{
    Console.WriteLine(numbers[num,st]);
}
else Console.WriteLine("Такого числа  массиве нет");


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10) ;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


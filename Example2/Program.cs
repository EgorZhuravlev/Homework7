/* Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

bool isParsedX = int.TryParse(Console.ReadLine(), out int X);
if (!isParsedX)
{
    Console.WriteLine("Данные ввели некорректно");
}

int[,] array = CreateRandom2DArray(3,4);
Print2DArray(array);
int[] position = FoundNumber(array, X);
PrintPosition(position, X);


int[,] CreateRandom2DArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(-10,10);
        }
    }
    
    return array;
}

int[] FoundNumber(int[,] array, int X)
{
    int[] position = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (X == array[i,j])
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
           
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
}

void PrintPosition(int[] position, int X)
{
    System.Console.WriteLine();
    if (position[0] > 0 && position[1] > 0) System.Console.WriteLine($"Число {X} находится в {position[0]}-й строке, {position[1]}-м столбце");
    else System.Console.WriteLine($"Число {X} отсутствует в заданном массиве");
    System.Console.WriteLine();
}

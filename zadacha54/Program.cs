// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.

void PrintMatrix(int[,] matr) // Вывод массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + $"\t");
        }
        System.Console.WriteLine();
    }
}

int[,] FillMatrix(int rows, int cols) // рандомное заполнение массива
{
    Random rand = new Random();
    int[,] array2d = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array2d[i, j] = rand.Next(0, 11);
        }
    }
    return array2d;
}

int InputNumbers(string str) //проверка введенного числа в размер массива
{
    int numbers;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out numbers))
        {
            while (numbers < 1)
            {
                System.Console.WriteLine("Размер массива не может иметь отрицательное или нулевое значение");
                System.Console.WriteLine("Введите число повторно: ");
                numbers = Convert.ToInt32(Console.ReadLine());
            }
            break;
        }
        else
        {
            Console.WriteLine("Ошибка!!! Введено не верное значение!");
        }
    }
    return numbers;
}

void Sorter(int[,] array) // сортировка массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int rows = InputNumbers("Введите число M: ");
int cols = InputNumbers("Введите число N: ");
System.Console.WriteLine();
int[,] array2d = FillMatrix(rows, cols);
System.Console.WriteLine("Исходный массив");
PrintMatrix(array2d);
System.Console.WriteLine();
System.Console.WriteLine("Отсортированный массив");
Sorter(array2d);
PrintMatrix(array2d);



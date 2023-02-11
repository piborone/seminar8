// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

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

void PrintMatrix(int[,] matr) // Вывод массива
{
    System.Console.WriteLine("Исходный массив");
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

void Sum(int[,] array) // сумма строки
{
    
    System.Console.WriteLine("Сумма каждой строки: ");
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        System.Console.Write(sum + "  ");
}
System.Console.WriteLine();
}

int Numberstring(int[,] array, int i)
{
  int sumnum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumnum += array[i,j];
  }
  return sumnum;
}



int rows = InputNumbers("Введите число M: ");
int cols = InputNumbers("Введите число N: ");
System.Console.WriteLine();
int[,] array2d = FillMatrix(rows, cols);
PrintMatrix(array2d);
Sum(array2d);
int minsum = 0;
int sumnum = Numberstring(array2d, 0);
for    (int i = 1;   i < array2d.GetLength(0); i++)
{
  int temp = Numberstring(array2d, i);
  if (sumnum > temp)
  {
    sumnum = temp;
    minsum = i;
  }
}
Console.WriteLine($"строка № {minsum+1} - с наименьшей суммой элементов ");

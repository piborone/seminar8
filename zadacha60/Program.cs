// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
//  построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2 


void PrintIndex(int[,,] array3d) // вывода индекса элементов массива
{
    for (int i=0; i < array3d.GetLength(0); i++)
    {
        for (int j=0; j < array3d.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k=0; k < array3d.GetLength(0); k++) 
            {
                Console.Write($"{array3d[i, j, k]}({i},{j},{k}) ");
                
            }
            
        }
    }
   
}


void FillArray(int[,,] array3d) // заполнения массива не повторяющимеся числами
{
    int count = 10;
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d [k, i, j] += count;
                count += 3;
            }
        }
    }
}


int[,,] array3d = new int[2, 2, 2];
FillArray(array3d);
PrintIndex(array3d);



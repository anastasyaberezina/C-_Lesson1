﻿// Нахождение минимального числа в массиве

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i<length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();

    void SelectionSort(int[] array)
    {
        for(int i=0; i<array.Length-1; i++)
        {
            int minPosision = i;
            for (int j = i+1; j<length; j++)
            {
                if(array[j]<array[minPosition]) minPosition=j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition]=temporary;
        }
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
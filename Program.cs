﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

int[] SizeRequeryArray()
{
    int dimensionArray = 0;
    while (dimensionArray < 1)
    {
        Console.WriteLine("Please, enter the dimension of array as an integer positive number:");
        dimensionArray = int.Parse(Console.ReadLine());
    }

    string dimensionString = String.Empty;
    int[] arraySize = new int[dimensionArray];
    for (int i = 1; i < dimensionArray; i++)
    {
        arraySize[i] = -1;
        while (arraySize[i] < 1)
        {
            Console.WriteLine($"Enter the size for {i} dimension as positive integer:");
            arraySize[i] = int.Parse(Console.ReadLine());
        }
    }
    return arraySize;
}

double[,] CreateArrayDblTwoDimension(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    var random = new Random();
    int integerPart = 0;
    int doubleSwitch = 0;
    double doublePart = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            integerPart = random.Next(-1000, 1001);
            doubleSwitch = random.Next(0, 2);
            if (doubleSwitch == 1) doublePart = Math.Round(random.NextDouble(), 3);
            else doublePart = 0;
            array[i, j] = integerPart + doublePart;
        }
    }
    return array;
}






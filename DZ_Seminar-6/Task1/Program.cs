﻿// Задача 41 : Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь

double[] EnterNumbers()  
{
    Console.Write("Введите числа через , ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(","); 
    double[] numbers = new double[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(arrayNumbers[i]);
    }
    return numbers;
}

void NegativeNumbers(double[] array)
{
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
         result++;
        }
    }
    Console.Write($"Кол-во отрицательных чисел = {result}");
}

double[] arr = EnterNumbers();
NegativeNumbers(arr);
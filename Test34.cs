/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
Размер массива вводим через консоль
*/


Console.WriteLine("Введите число. Оно определит длину массива");
int n = int.Parse(Console.ReadLine()!);

int[] array = GenArray(n, 99, 1000);
PrintArray(array);

int[] GenArray(int n, int min, int max)     // Функция, генерирующая массив
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)     //Выводит массив на печать
{
  for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumber(int[] array)   //Функция считает колличество четных чисел в массиве
{
    int amount = 0;
    int am = 0;
    for (int i = 0; i < array.Length; i++)
    {
        am = array[i] % 2;
        if (am == 0)
        {
            amount = amount +1;
        }
    }
    return amount;
}

 EvenNumber(array);
 Console.WriteLine( EvenNumber(array));
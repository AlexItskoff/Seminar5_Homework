/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Размер массива, минимальное значение и максимальное значение вводим через консоль

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите число. Это будет размер массива");
int n = int.Parse(Console.ReadLine()!);

if (n<0)
{
    n = -n;
    Console.WriteLine(n);              // делаем число n положительным
}

Console.WriteLine("Введите число. Это будет минимальное значение массива");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число. Это будет максимальное  значение массива");
int max = int.Parse(Console.ReadLine()!);

if (min>=max)

{
   Console.WriteLine(" Минимум меньше максимума! Введите числа корректно!");  // 
   // объясняем пользователю ошибку, которая возникнет, если он перепутает максимум и минимум
}

int[] GenerateArray()     // Функция для генерации массива
{
   int[] array = new int[n];
   
   for(n=0; n< array.Length; n++)
  {
     array[n] = new Random().Next( min,  max);
  }
    return array;
}


void PrintArray(int[] array)   // Процедура для вывода массива на печать
{
   for(n=0; n< array.Length; n++)
   {
   Console.Write(array[n] + "  ");
   }
   Console.WriteLine();
}

int[] array = GenerateArray();  // Генерируем массив
PrintArray( array);             // Выводим массив на печать

int EvenSum(int[] array)       // Функция для подсчета суммы чисел массива с нечетными индексами
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i %2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.WriteLine( "Сумма чисел с нечетным индексом" +  "  " + EvenSum(array));  //вывдим итог







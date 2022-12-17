/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Размер массива, минимальное значение и максимальное значение вводим через консоль
Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()

[3 7 22 2 78] -> 76
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
   Console.WriteLine(" Минимум меньше максимума! Введите числа корректно!"); 
   return;
   // объясняем пользователю ошибку, которая возникнет, если он перепутает максимум и минимум
}

double doublePart = new Random().NextDouble();  // превращаем числа типа int  в double 
double number = doublePart * (max - min) + min;  // и оставляем у них два знака после запятой
number = Math.Round(number , 2);
//Console.WriteLine(number);



double[] GenerateDoubleArray(int length, int min, int max)     // Функция для генерации массива
{
   double[] array = new double[length];
   
   for(n=0; n< array.Length; n++)
  { 
    double number = new Random().NextDouble() * (max - min) + min;
     array[n] = Math.Round(number , 2);
  }
    return array;
}

void PrintDoubleArray(double[] array)   // Процедура для вывода массива на печать
{
   for(n=0; n< array.Length; n++)
   {
   Console.Write(array[n] + "  ");
   }
   Console.WriteLine();
}

double [] array = GenerateDoubleArray(n, min, max) ;  // Генерируем массив
PrintDoubleArray(array);                              // Выводим его на печать

 double findMax(double[] arr)              // Функция для поиска максимального значения массива
{
     double arrMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > arrMax)
        {
            arrMax = array[i];
        }
    }
    return arrMax;
}

double findMin(double[] arr)   // Функция для нахождения минимального значения массива
{
     double arrMin = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < arrMin)
        {
            arrMin = array[i];
        }
    }
    return arrMin;
}

double findResult(double[] arr)   // Функция для вычисления разности между максимальным 
                                  // и минимальным значениями массива
{
   double minim = findMin(array);
   double maxim = findMax(array);

   double finalResult = maxim - minim;
   //finalResult = Math.Round(number , 2);
   return finalResult;
}
//************************************************************************************
//  Выводим на печать итоги работы
  Console.WriteLine(" Максимальное число массива - " + " " + findMax(array));      
  Console.WriteLine(" Минимальное число массива - " + " " + findMin(array)); 
  Console.WriteLine(" Финальный результат - " + " " + Math.Round(findResult(array), 2)); 


   

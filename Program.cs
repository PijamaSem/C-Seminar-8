// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
/*
int[,] Create2dArrya() // Создание двух мерного массива
{
    Console.Write("Input number of rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min_Value = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max_Value = Convert.ToInt32(Console.ReadLine());
    int[,] CreateArrya = new int[row, colums];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colums; j++)
            CreateArrya[i, j] = new Random().Next(min_Value, max_Value);
    return CreateArrya;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}
void SortRowsOfArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                int maxValue = array[i, j];
                for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i, k] > array[i, j])
                            {
                                int tmp = array[i, j];
                                array[i, j] = array[i, k];
                                array[i, k] = tmp;
                            }
                    }
            }
    }
}
int[,] initMatrix = Create2dArrya();
ShowArray(initMatrix);
SortRowsOfArray(initMatrix);
Console.WriteLine();
ShowArray(initMatrix);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
// Приветсвие
Console.WriteLine(
    "Эта программа находит создает массив из случайных чисел и находит строку с наименьшей суммой элементов!"
);

// Методы
int[,] Create2dArrya() // Создание двух мерного массива
{
    Console.Write("Input number of rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min_Value = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max_Value = Convert.ToInt32(Console.ReadLine());
    int[,] CreateArrya = new int[row, colums];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colums; j++)
            CreateArrya[i, j] = new Random().Next(min_Value, max_Value);
    return CreateArrya;
}
void PrintArray(int[] array) // Вывод в консоль массива
{
    Console.Write("Суммы элементов в строках массива:[");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("\b\b]");
}
void Show2dArray(int[,] array) // Вывод в консоль двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine(" ");
    }
}
int[] RowSum(int[,] array) //Расчет сумм строк массива
{
    int[] RowSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i, j];
        RowSum[i] = sum;
    }
    return RowSum;
}
void MinValue(int[] array)
{
    int minValue = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < minValue)
            indexMin = i;
    Console.WriteLine(
        $"В данном массиве в <{indexMin}> строчке наименьшая сумма элементов. Если забыл, то отчет начинается с <0>"
    );
}

// Вызовы
int[,] initMatrix = Create2dArrya();
Show2dArray(initMatrix);
Console.WriteLine();
int[] Sum = RowSum(initMatrix);
Console.WriteLine();
MinValue(Sum);
Console.WriteLine();
Console.WriteLine("Чтобы тебе проще было перепроветить я выведу сумму элементов строк");
PrintArray(Sum);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Console.WriteLine("Введите размеры сторону квадратного массива, лучше 4х4 но можно и другого и заполню его по спирали ");
int[,] Create2dArrya() // Создание двух мерного массива
{
    Console.Write("ввод размера массива тут: ");
    int row = Convert.ToInt32(Console.ReadLine());
    int[,] CreateArrya = new int[row, row];
    return CreateArrya;
}
void Show2dArray(int[,] array) // Вывод в консоль двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine(" ");
    }
}
void SnakeFillArray(int row, int colum, int[,] array, int count){
while (count <= array.Length)
{
  array[row, colum] = count;
  count++;
  if (row <= colum + 1 && row + colum < array.GetLength(1) - 1)     colum++;  // движение вправо
  else if (row < colum && row + colum >= array.GetLength(0) - 1)      row++;  // движение вниз
  else if (row >= colum && row + colum > array.GetLength(1) - 1)     colum--; // движение налево
  else  row--;                                                                // движение вверх  
}
}
int [,]Matrix=Create2dArrya();
SnakeFillArray(0,0,Matrix,1);
Show2dArray(Matrix);
*/
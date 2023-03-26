// Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

Console.WriteLine("введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[sizeArray];
for(int i = 0; i < array1.Length; i++)
{
    array1[i] = new Random().Next(1, 20);
}
Console.WriteLine("Первый массив: ");
for(int i = 0; i < array1.Length; i++)
{
    Console.Write(array1[i] + "| ");
}
Console.WriteLine();// пустая строка для разделения результатов

int[] array2 = new int[array1.Length];
for(int i = 0; i < array2.Length; i++)
{
    array2 = array1;
}

Console.WriteLine("Второй массив: ");
for(int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i] + "| ");
}
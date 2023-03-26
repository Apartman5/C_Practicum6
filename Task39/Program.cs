// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
    return array;
}

int[] ReverseArray(int[] array)
{

    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

int Prompt()
{
    Console.WriteLine("Input number");
    return Convert.ToInt32(Console.ReadLine());
}

// const int SIZE = 8;
int[] array = GenerateArray(Prompt());
Console.WriteLine(string.Join(",", array));
Console.WriteLine(string.Join(",", ReverseArray(array)));
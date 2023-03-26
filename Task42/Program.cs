// Задача: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("введите целое число");
int decNum = Convert.ToInt32(Console.ReadLine());

string TenToTwo(int decNum)
{
    string firstResult = " ";
    while(decNum > 0)
    {
        string result = Convert.ToString(decNum % 2);
        result = result + firstResult;
        firstResult = result;
        decNum /= 2;
    }
    return firstResult;
}

Console.WriteLine(TenToTwo(decNum));
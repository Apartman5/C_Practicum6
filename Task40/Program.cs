int Prompt(string message)
{
Console.WriteLine(message);
string ReadInput = Console.ReadLine();
int result = int.Parse(ReadInput);
return result;
}
int a = Prompt("Введите первое число");
int b = Prompt("Введите второе число");
int c = Prompt("Введите третье число");

// Неидеальный вариант, хоть и правильный
// if(b + c > a)
// {
//     if(c + a > b)
//     {
//         if(a + b > c)
//         {
//             Console.WriteLine("Такой треугольник существует");
//         }
//         else Console.WriteLine("Такой треугольник не существует");
//     }
//     else Console.WriteLine("Такой треугольник не существует");
// }
// else Console.WriteLine("Такой треугольник не существует");


//Идеальный код:
if(b + c > a && c + a > b && a + b > c)
    Console.WriteLine("Такой треугольник существует");
    else Console.WriteLine("Такой треугольник не существует");
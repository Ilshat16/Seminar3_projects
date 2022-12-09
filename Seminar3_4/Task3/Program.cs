//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//Методы
int FindFactorial(int number)
{
    int fatorial = 1;
    for (int i = 1; i <= number; i++)
    {
        fatorial *= i;
    }
    return fatorial;
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Ввод данных
int number = EnterData("Ввелите число: ");
//Выполнение программы
int result = FindFactorial(number);
//Вывод результата
Console.WriteLine($"Произведение чисел от 1 до {number} равно: {result}");
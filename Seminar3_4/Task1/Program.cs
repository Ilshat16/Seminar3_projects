//Методы
int FindSum(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
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
int result = FindSum(number);
//Вывод результата
Console.WriteLine($"Сумма чисел от 1 до {number} равна: {result}");
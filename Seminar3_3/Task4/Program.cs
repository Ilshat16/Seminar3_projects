//Методы
void FindNumbers(int number)
{
    double result = 0;
    int n = 1;
    Console.Write($"Квадраты чисел от 1 до {number}: ");
    while (n < number)
    {
        result = Math.Pow(n, 2);
        Console.Write($"{result}, ");
        n++;
    }
    Console.WriteLine(number*number);
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Запрос числа
int number = EnterData("Введите число: ");
//Анализ данных
FindNumbers(number);

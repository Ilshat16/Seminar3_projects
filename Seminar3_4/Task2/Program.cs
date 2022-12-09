//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Методы
int FindCount(string number)
{
    int result = number.Length;
    return result;
}
string EnterData(string text)
{
    Console.Write(text);
    string number = Console.ReadLine();
    return number;
}
//Ввод данных
string number = EnterData("Ввелите число: ");
//Выполнение программы
int result = FindCount(number);
//Вывод результата
Console.WriteLine($"Количество цифр в числе {number} равно: {result}");
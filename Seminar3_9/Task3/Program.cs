// Напишите программу, которая на вход принимает два число
// и возвращает сумму его цифр.

int SumDigits(int num)
{
    if (num / 10 == 0) return num;
    return num % 10 + SumDigits(num / 10);
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigits(number)}");
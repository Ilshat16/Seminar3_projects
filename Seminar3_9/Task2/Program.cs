// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 

string PrintNumbers(int m, int n)
{
    if (m == n) return n.ToString();
    return m.ToString() + ", " + PrintNumbers(m + 1, n);
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterData("Введите число M: ");
int n = EnterData("Введите число N: ");
System.Console.WriteLine(PrintNumbers(m, n));
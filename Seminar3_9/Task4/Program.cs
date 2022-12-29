// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.

int Exponentiation(int a, int b)
{
    if (b == 0) return 1;
    return a * Exponentiation(a, b - 1);
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = EnterData("Введите число A: ");
int b = EnterData("Введите число B: ");
System.Console.WriteLine($"А ({a}) в степени В ({b}) равно {Exponentiation(a, b)}");
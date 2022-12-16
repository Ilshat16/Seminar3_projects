// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Числа Фибоначчи— числовая последовательность, каждый элемент которой равен сумме двух предыдущих.
string Fibonacci (int n1, int n2, int num)
{
    int count = 2;
    int n3 = 0;
    int n4 = 0;
    string result = "";
    while (count != num - 1)
    {
        result = result + $"{n1} " + $"{n2} ";
        n3 = n1 + n2;
        n4 = n3 + n2;
        n1 = n3;
        n2 = n4;
        count += 1;
    }
    return result;
}
int n1 = 0;
int n2 = 1;
int num = 7;
string result = Fibonacci(n1, n2, num);
Console.WriteLine(result);
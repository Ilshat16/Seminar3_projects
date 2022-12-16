// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Каждая сторона треугольника меньше суммы двух других сторон.

//Методы
int TriangleInput(string tekst)
{
    Console.Write(tekst);
    int num = int.Parse(Console.ReadLine());
    return num;
}
void TriangleCheck(int a, int b, int c)
{
    if (a+b>c & b+c >a & c+a>b)
    Console.WriteLine("Треугольник с такими сторонами существует");
    else Console.WriteLine("Треугольника с такими сторонами не существует");
}
//Ввод данных
int a = TriangleInput("Введите сторону а: ");
int b = TriangleInput("Введите сторону b: ");
int c = TriangleInput("Введите сторону c: ");
//Проверка, существует ли такой треугольник
TriangleCheck(a, b, c);
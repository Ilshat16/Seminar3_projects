//Методы
double FindDistance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return result;
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Запрос координат
int x1 = EnterData("Введите координаты Х1: ");
int y1 = EnterData("Введите координаты Y1: ");
int x2 = EnterData("Введите координаты Х2: ");
int y2 = EnterData("Введите координаты Y2: ");
//Анализ данных
double result = FindDistance(x1, y1, x2, y2);
//Вывод информации
Console.WriteLine($"Расстояние между данными точками равно {result}");
//Методы
int FindQuarter(int x, int y)
{
    int result = 0;
    if (x > 0 & y > 0) result = 1;
    if (x < 0 & y > 0) result = 2;
    if (x < 0 & y < 0) result = 3;
    if (x > 0 & y < 0) result = 4;
    return result;
}
int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Запрос координат числа
int x = EnterData("Введите координаты Х: ");
int y = EnterData("Введите координаты Y: ");
//Анализ данных
int number = FindQuarter(x, y);
//Вывод информации
Console.WriteLine($"Точка находится в {number} четверти");
//Методы
double FindQuarter(int quarter)
{
    string result = "";
    if (quarter == 1) return "x > 0 & y > 0";
    if (quarter == 2) return "x < 0 & y > 0";
    if (quarter == 3) return "x < 0 & y < 0";
    if (quarter == 4) return "x > 0 & y < 0";
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Запрос четверти
int quarter = EnterData("Номер четверти: ");
//Анализ данных
double result = FindQuarter(quarter);
//Вывод информации
Console.WriteLine($"В четверти {quarter}: {result}");
//Методы
string FindQuarter(int quarter)
{
    string result = "";
    if (quarter == 1) result = "x > 0 & y > 0";
    if (quarter == 2) result = "x < 0 & y > 0";
    if (quarter == 3) result = "x < 0 & y < 0";
    if (quarter == 4) result = "x > 0 & y < 0";
    return result;
}
int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Запрос четверти
int quarter = EnterData("Номер четверти: ");
//Анализ данных
string result = FindQuarter(quarter);
//Вывод информации
Console.WriteLine($"В четверти {quarter} {result}");
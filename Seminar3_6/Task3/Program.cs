// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//Методы
int EnderData(string tekst)
{
    Console.Write(tekst);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void ConvertToBinary(int num)
{
    string binNum = "";
    while (num != 0)
    {
        binNum = $"{num % 2}" + binNum;
        num /= 2;
    }
    Console.WriteLine(binNum);
    // string result = "";
    // for (int i = 0; i < binNum.Length; i++)
    // {
    //     result += binNum[binNum.Length - 1 - i];
    // }
    // Console.WriteLine(result);
}
//Ввод числа
int number = EnderData("Введите десятичное число: ");
//Перевод в вдвоичный
ConvertToBinary(number);
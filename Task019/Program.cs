// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}
string CheckPalindrome(string text)
{
    string result = "Введенное значение является палиндромом!";
    for (int i = 0; i<(text.Length)/2;i++)
    {
        if (text[i] != text[text.Length-1-i])
        {
            result = "Введенное значение НЕ является палиндромом!";
        }
    }
    return result;
}

string text = DataEntry("Введите число: ");
string result = CheckPalindrome(text);
Console.WriteLine(result);

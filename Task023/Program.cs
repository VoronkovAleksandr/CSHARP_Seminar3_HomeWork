// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int n = int.Parse(DataEntry("Введите число N: "));

for (int i = 1; i <= n; i++)
{
    Console.Write(Math.Pow(i,3) + " ");
}
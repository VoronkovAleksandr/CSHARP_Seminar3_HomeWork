﻿// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

double Distance(double x1,double y1,double z1, double x2,double y2,double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1), 2)+Math.Pow((z2 - z1), 2));
    return distance;
}

double x1 = double.Parse(DataEntry("Введите координату X первой точки: "));
double y1 = double.Parse(DataEntry("Введите координату Y первой точки: "));
double z1 = double.Parse(DataEntry("Введите координату Z первой точки: "));
double x2 = double.Parse(DataEntry("Введите координату X второй точки: "));
double y2 = double.Parse(DataEntry("Введите координату Y второй точки: "));
double z2 = double.Parse(DataEntry("Введите координату Z второй точки: "));

double distance = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine("Расстояние между точками: " + distance);
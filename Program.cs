
﻿// Задача.19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? str = Console.ReadLine(); // добавляем "?" по совету OmniSharp чтобы избавиться от жёлтого мусора в терминале при запуске

if (str!.Length != 5)// добавляем "!" по совету OmniSharp чтобы избавиться от жёлтого мусора в терминале при запуске
{
System.Console.WriteLine("Не знаете что такое пятизначное число? Вы самое слабое звено. Прощайте!");
}
else if (str[0] == str[4] && str[1] == str[3])
{
    System.Console.WriteLine("Введённое вами число является палиндромом");
}
else
{
    System.Console.WriteLine("Введённое вами число не является палиндромом");
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int [] aCoordinate = new int [3];
Console.WriteLine("Введите x первой точки");
aCoordinate [0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у первой точки");
aCoordinate [1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки");
aCoordinate [2] = Convert.ToInt32(Console.ReadLine());

int [] bCoordinate = new int [3];
Console.WriteLine("Введите х второй точки");
bCoordinate [0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у второй точки");
bCoordinate [1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z второй точки");
bCoordinate [2] = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Math.Round((Math.Sqrt((Math.Pow((bCoordinate [0] - aCoordinate [0]),2)) + (Math.Pow((bCoordinate [1] - aCoordinate [1]),2)) + (Math.Pow((bCoordinate [2] - aCoordinate [2]),2))),2),3));

double result = Math.Sqrt(Math.Pow((bCoordinate [0] - aCoordinate[0]), 2) + Math.Pow((bCoordinate[1] - aCoordinate[1]), 2) + Math.Pow((bCoordinate[2] - aCoordinate[2]), 2));

System.Console.WriteLine(Math.Round(result, 2));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < number; i++)
{
    Console.Write(Math.Pow(i , 3) + " ");
}
﻿// System.Console.WriteLine("Введите число");
// string str = System.Console.ReadLine();

// if (str [0] == str [4])
// {
//     System.Console.WriteLine("Введенное число - палиндром");
// }
// else 
// {
//     (System.Console.WriteLine("Введенное число - не палиндром"));
// }

﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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
    System.Console.WriteLine
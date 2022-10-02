using System;
public class Mainclass
{
    public static void Main()
    {
        Console.WriteLine("Конечное число равно 546. Найти исходное.");
        Console.WriteLine("Начало расчетов...");
        string a = "5"; // Число сотен (Первая цифра)
        string b = "4"; // Число десятков (Вторая цифра)
        string c = "6"; // Число единиц (Третья цифра)
        string[] n0 = { b, a, c }; // По условию, вторая цифра (b) меняется местами с первой цифрой (a)
        string x = string.Join(null, n0);
        Console.WriteLine($"Начальное число равно {x}");
    }
}
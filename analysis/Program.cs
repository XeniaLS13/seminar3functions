// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// bool <- int

Console.Write("Введите порядковый номер дня ");
int day = Convert.ToInt32(Console.ReadLine());
if (day % 7 => 5)
    Console.WriteLine(true);
else
    Console.WriteLine(false);


Console.Write("Введите порядковый номер дня ");
int day = Convert.ToInt32(Console.ReadLine());
string[] dayOfWeek = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
Console.WriteLine(day % 7);
Console.WriteLine(dayOfWeek[day % 7]);
if ((day % 7) => 5)
    Console.WriteLine(true);
else
    Console.WriteLine(false);


string GetInfoByDayWeek(int day)
{
    if (day = 6 || day = 7)
        return ("выходной");
    else if (day => 1 && day <= 5)
        return ("будни");
    else
        return ("вы на другой ...");
}
Console.WriteLine(GetInfoByDayWeek(5));

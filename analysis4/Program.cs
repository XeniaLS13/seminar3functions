// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

int number = 123456895;
    if(number<100)
{
    Console.WriteLine("неподходящее число");
}
else
{
while (number > 100)
{
    number = number /10;
    Console.WriteLine(number);
}
Console.WriteLine(number % 10);
}

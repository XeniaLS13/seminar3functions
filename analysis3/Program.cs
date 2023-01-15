// Если цифр больше 3 (5)
//           КТСДЕ  
//int number = 12345;
//Console.WriteLine(number % 100 / 10);

// Решение задания по поиску второй цифры пятизначного числа

int number = 12345;

while(number > 100)
{
    number = number / 10;
    Console.WriteLine(number);
}
Console.WriteLine(number % 10);

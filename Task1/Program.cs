// Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 2D пространстве. 
// * A(3,6), B(2,1) ->5,09
// * A(7,-5), B(1, -1)-> 7,21

int a1 = 3;
int a2 = 2;
int b1 = 6;
int b2 = 1;

double distance = GetDistance(a1, a2, b1, b2);
Console.WriteLine(distance);

double GetDistance(int a1, int a2, int b1, int b2)
{
    return Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2));
}
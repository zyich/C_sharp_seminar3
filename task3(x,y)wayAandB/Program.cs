/*
Напишите программу, которая принимает на 
вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

void Print(string text)
{
   Console.WriteLine(text);
}


int GetIntNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double GetDistance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
    return result;
}


Print("insert one by one x1, y2, x2, y2 :");
int x1 = GetIntNum();
int y1 = GetIntNum();
int x2 = GetIntNum();
int y2 = GetIntNum();

double result = GetDistance(x1, y1, x2, y2);
Print($"distance between points is {result}");






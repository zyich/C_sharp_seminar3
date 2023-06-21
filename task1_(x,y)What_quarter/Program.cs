/* Напишите программу, которая принимает 
на вход координаты точки (X и Y),
Причем X не равно 0 и Y не равно 0 и 
выдает номер четверти плоскости , в которой 
находится эта точка .
*/

string data = "data";
string error = "error";
string result = "result";


void Print(string text, string arg)
{
    switch (arg)
    {
        case "data": Console.ForegroundColor = ConsoleColor.DarkMagenta;
        break;
        
        case "result": Console.ForegroundColor = ConsoleColor.DarkGreen;
        break;

        case "error": Console.ForegroundColor = ConsoleColor.DarkRed;
        break;
    
    }
    Console.WriteLine(text);
    Console.ResetColor();
}

int GetIntNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void FindQuarter(int x, int y)
{
    if(x == 0 || y == 0)
    {
        Print("Our or both coordinate equal 0", error );
    }
    else 
    {
        switch (x, y)
        {
            case (>0 , >0) :  Print("First quarter.", result);
            break;

            case (<0 , >0) :  Print("Second quarter.", result);
            break;

            case (<0 , <0) :  Print("Third quarter.", result);
            break;

            case (>0 , <0) :  Print("Fourth quarter.", result);
            break;
        }
    }
}

Print("input x coordinate", "data");
int coordinateX = GetIntNum();

Print("input Y coordinate", "data");
int coordinateY = GetIntNum();



FindQuarter (coordinateX, coordinateY);


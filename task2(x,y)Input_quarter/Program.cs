/* 
Напишите программу, которая по заданному
 номеру четверти, показывает диапазон
  возможных координат 
  точек в этой четверти (x и y).
  


string data = "data";
string error = "error";
string result = "result";
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


void FindCoordinate(int number)
{
    if(number > 0 && number < 5)
    {
        switch (number)
        {
            case 1 : Print("X > 0, Y > 0");
            break;

            case 2 :  Print("X < 0, Y > 0");
            break;

            case 3 :  Print("X < 0, Y < 0");
            break;

            case 4 :  Print("X > 0, Y < 0");
            break;
        }
    }
    else {
        Print("insert correct number");
    }
}

Print("input quarter");
int number = GetIntNum();
FindCoordinate(number);






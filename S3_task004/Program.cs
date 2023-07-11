// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)

{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int num1 = Prompt("введите четверть");
GetResult(num1);
void GetResult(int num1)
{

    if (num1 == 1)
    {
        Console.WriteLine("X>0, Y>0");
    }
    else if (num1 == 2)
    {
        Console.WriteLine("X<0, Y>0");
    }
    else if (num1 == 3)
    {
        Console.WriteLine("X<0, Y<0");
    }
    else if (num1 == 4)
    {
        Console.WriteLine("X>0, Y<0");
    }
}

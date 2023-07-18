// Задача №12
// Напишите программу, которая на вход будет принимать два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток на деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

int ResultOfDivision()
{
    int resultOfDivision = number1 / number2;
    return resultOfDivision;
}
int resultnumber = ResultOfDivision();

if (number1 / number2 == number2)
{
    Console.Write("Кратно!");
}
else
{
    Console.Write("-> не кратно, остаток " + (number1 - (resultnumber * number2)));
}




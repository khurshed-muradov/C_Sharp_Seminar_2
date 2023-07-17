//Задача №11
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int GetRandomNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int GetFirstDigit(int number1)
{
    return number1 / 100;
}

int GetLastDigit(int number1)
{
    return number1 % 10;
}

void PrintNumber(int num1)
{
    Console.Write(num1 + " ");
}

void ShowLargestDigit(int digit1, int digit2)
{
    if (digit1 > digit2)
    {
        Console.Write("-> " + digit1);
    }
    else
    {
        Console.Write("-> " + digit2);
    }
}

GetRandomNumber(number);
PrintNumber(num);
int firstDigit = GetFirstDigit(num);
int lastDigit = GetLastDigit(num);
ShowLargestDigit(firstDigit, lastDigit);
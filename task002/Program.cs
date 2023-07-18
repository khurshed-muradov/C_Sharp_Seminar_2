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

int num = GetRandomNumber();
PrintNumber(num);
int firstDigit = GetFirstDigit(num);
PrintNumber(firstDigit);
int lastDigit = GetLastDigit(num);
PrintNumber(lastDigit);
Console.Write("-> " + firstDigit + lastDigit);




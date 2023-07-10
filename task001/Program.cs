// Напишите программу, которая вводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int GetRandomNumber()
{
    int number = new Random().Next(10, 100);
    Console.WriteLine(number);
    return number;
}

int GetFirstDigit(int number1)
{
    number1 = number1 / 10;
    Console.WriteLine(number1);
    return number1;
}

int GetSecondDigit(int number2)
{
    number2 = number2 % 10;
    Console.WriteLine(number2);
    return number2;
}

int num = GetRandomNumber();
int firstDigit = GetFirstDigit(num);
int secondDigit = GetSecondDigit(num);





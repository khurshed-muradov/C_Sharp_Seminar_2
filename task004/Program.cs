// 14 Задача.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> Нет
// 46 -> Нет
// 161 -> Да

int EnteredNumber()
{
    int enteredNumber = int.Parse(Console.ReadLine());
    return enteredNumber;
}
Console.WriteLine("Введите число: ");

int enteredNumber = EnteredNumber();

int number1 = 7;
int number2 = 23;

if (enteredNumber % number1 == 0 && enteredNumber % number2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
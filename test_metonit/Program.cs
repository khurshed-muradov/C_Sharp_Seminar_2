// void SayHelloRu()
// {
//     Console.WriteLine("Привет");
// }

// void SayHelloEn()
// {
//     Console.WriteLine("Hello");
// }

// void SayHelloFr()
// {
//     Console.WriteLine("Salut");
// }

// string language = "ru";

// switch (language)
// {
//     case "en":
//         SayHelloEn();
//         break;
//     case "ru":
//         SayHelloRu();
//         break;
//     case "fr":
//         SayHelloFr();
//         break;
// }




// void PrintMessage(string message)
// {
//     Console.WriteLine(message);
// }

// PrintMessage("Hello work");
// PrintMessage("Hello METANIT.COM");
// PrintMessage("Hello C#");




// void Sum(int x, int y)
// {
//     int result = x + y;
//     Console.WriteLine($"{x} + {y} = {result}");
// }

// Sum(5, 6);
// Sum(10, 20);




// void Sum(int x, int y)
// {
//     Console.WriteLine($"{x} + {y} = {x + y}");
// }

// int a = 10, b = 15, c = 6;
// Sum(a, b);                  // 10 + 15 = 25
// Sum(3, c);                  // 3 + 6 = 9
// Sum(14, 4 + c);             // 14 + 10 = 24





// void Sum(int x, int y)
// {
//     Console.WriteLine($"{x} + {y} = {x + y}");
// }

// int a = 5, b = 15;
// Sum(a, b);




// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Name: {name}  Age: {age}");
// }

// PrintPerson("Imran", 12); // Name: Tom  Age: 24






// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Name: {name}  Age: {age}");
// }

// byte b = 37;
// PrintPerson("Tom", b); // Name: Tom  Age: 37





// void PrintPerson(string name, int age = 1, string company = "Undefined")
// {
//     Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
// }
// int age = 12;
// string company = "Family";
// PrintPerson("Imran", age, company);





void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Tom", 37, "Microsoft");  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson("Tom", 37);               // Name: Tom  Age: 37  Company: Undefined
PrintPerson("Tom");                   // Name: Tom  Age: 1   Company: Undefined
using IronSharp.OOP.Core; 

int sum = Calculator.Add(10, 20);
Console.WriteLine($"Addition: {sum}");

int totalAll = Calculator.SumAll(1, 2, 3, 4, 5);
Console.WriteLine($"SumAll (varargs): {totalAll}");

string formatted = Calculator.FormatResult(100); 
Console.WriteLine(formatted);

string formattedCustom = Calculator.FormatResult(100, "Total: ");
Console.WriteLine(formattedCustom);

bool success = Calculator.TryDivide(10, 3, out int divisionResult);
if (success)
{
    Console.WriteLine($"Division result: {divisionResult}");
}
else
{
    Console.WriteLine("Cannot divide by zero!");
}

Greeter myGreeter = new Greeter("Good evening");
Console.WriteLine(myGreeter.SayHello("Alice"));
Console.WriteLine(myGreeter.SayHello("Bob", "Mr."));
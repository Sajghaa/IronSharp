Console.WriteLine("Iron is officially forged");

int age = 30;
double pi =  3.14159;
string name = "Alex";
bool isLearning = true;

var year = 2026;

Console.WriteLine($"Hello {name}, you are {age} years old");
Console.WriteLine($"We are in {year} and Pi is {pi} ");

if (age >= 18)
{
    Console.WriteLine($"{name} is an adult.");
}
else
{
    Console.WriteLine($"{name} is a minor");
}

string weather = "Sunny";
string action = weather switch
{
    "Sunny" => "Go outside",
    "Rainy" => "Take an umbrella",
    "Cloudy" => "Bring a jacket",
    _=> "Check the forecast"    
};

Console.WriteLine($"Weather advice: {action}");


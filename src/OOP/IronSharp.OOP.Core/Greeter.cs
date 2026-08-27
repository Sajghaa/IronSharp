namespace IronSharp.OOP.Core;

public class Greeter
{

    public string Greeting { get; set; }

    public Greeter(string greeting)
    {
        Greeting = greeting;
    }

    public string SayHello(string name)
    {
        return $"{Greeting}, {name}!";
    }

    public string SayHello(string name, string title)
    {
        return $"{Greeting}, {title} {name}!";
    }
}
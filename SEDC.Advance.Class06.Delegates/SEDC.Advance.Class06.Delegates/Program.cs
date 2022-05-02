// See https://aka.ms/new-console-template for more information



SayDelegate sayDelegate = new SayDelegate(WriteToConsole);
SayDelegate sayWithColor = new SayDelegate(WriteWithRedColor);


sayDelegate("Hello world from delegate");
sayWithColor("This text is red");

SaySomething(sayWithColor, 1);
SaySomething(WriteWithRedColor, 2);  


static void WriteToConsole (string text)
{
    Console.WriteLine(text);
}

static void WriteWithRedColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

static void SaySomething(SayDelegate sayMechanism, int counter)
{
    sayMechanism($"Text from method {counter}");
}


delegate void SayDelegate(string text);

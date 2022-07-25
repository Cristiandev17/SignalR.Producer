// See https://aka.ms/new-console-template for more information

using MessageProducer;

var key = "1";
var message = "";

Console.WriteLine("Press any key to connect...");
Console.ReadLine();

Main main = new Main();
main.Connect();

while (key == "1")
{
    if (!string.IsNullOrEmpty(message))
    {
        main.SendMessage(message);
    }

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\t1 - New Message");
    Console.WriteLine("\t2 - Close app");
    Console.Write("Your option? ");
    key = Console.ReadLine();

    if (key == "1")
    {
        Console.WriteLine("Write a new message");
        message = Console.ReadLine();
    }
}

// See https://aka.ms/new-console-template for more information
//import the installed dependency
using Humanizer;


Console.WriteLine("Hello, World!");

//create methods using the dependency
static void HumanizerQuantities(){
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(2));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizerDates(){
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-36).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
}

//call the defined functions
HumanizerQuantities();
HumanizerDates();


Console.WriteLine("This is a better world");
Console.WriteLine("Hello World");
Console.WriteLine("Hello world");
Console.WriteLine("Hello world");
Console.WriteLine("Hello world");
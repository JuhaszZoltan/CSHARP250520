Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 15);

string[] names = ["Zoltán", "Sándor", "Dezső", "Anikó"];
Console.WriteLine("GitHub");
Console.WriteLine($"This prg created by: {string.Join(", ", names)}");

Console.WriteLine("some randompy placed star :333");

for (int i = 0; i < 100; i++)
{
    Console.SetCursorPosition(
        left: Random.Shared.Next(Console.WindowWidth -1),
        top: Random.Shared.Next(3, Console.WindowHeight));
    Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 15);
    Console.Write("*");
}

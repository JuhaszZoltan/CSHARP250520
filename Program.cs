Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 15);

string[] names = ["Zoltán", "Sándor"];

Console.WriteLine($"This prg created by: {string.Join(", ", names)}");

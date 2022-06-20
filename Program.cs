Console.WriteLine("Enter day of birth in format: dd.mm.yyyy");

TimeSpan timeSpan = DateTime.Now - DateTime.Parse(Console.ReadLine());

Console.WriteLine("You were born: {0} days and {1} hours ago", timeSpan.Days, timeSpan.Hours);


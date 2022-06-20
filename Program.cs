// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter year of birth");
int yearOfBirth = int.Parse(Console.ReadLine());

Console.WriteLine("Enter month of birth");
int monthOfBirth = int.Parse(Console.ReadLine());

Console.WriteLine("Enter day of birth");
int dayOfBirth = int.Parse(Console.ReadLine());

DateTime dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

TimeSpan timeSpan = DateTime.Now - dateOfBirth;

Console.WriteLine($"Your were born: {timeSpan.TotalDays} days ago");

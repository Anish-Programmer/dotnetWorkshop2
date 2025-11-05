// 1. Birthdate (change to your real birthdate)
DateTime birthDate = new DateTime(2004, 11, 27);

// 2. Current date/time
DateTime currentDate = DateTime.Now;

// 3. Calculate age using TimeSpan from DateTime subtraction
TimeSpan ageSpan = currentDate - birthDate;

// Convert days to years (approximate)
int ageInYears = (int)(ageSpan.TotalDays / 365.25);

// 4. Print results
Console.WriteLine($"Birthdate: {birthDate}");
Console.WriteLine($"Current Date: {currentDate}");
Console.WriteLine($"Age (years): {ageInYears}");

// 5. Add 10 days to birthdate
DateTime futureDate = birthDate.AddDays(10);
Console.WriteLine($"Birthdate + 10 days: {futureDate}");
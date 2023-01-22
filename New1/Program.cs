using System;

List<string> daysofweek = new List<string>();
daysofweek.Add("Poniedziałek");
daysofweek.Add("Wtorek");
daysofweek.Add("Środa");
daysofweek.Add("Czwartek");
daysofweek.Add("Piątek");
daysofweek.Add("Sobota");
daysofweek.Add("Niedziela");

foreach (var Day in daysofweek)
    Console.WriteLine(Day);
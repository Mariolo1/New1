using New1;
using System;

var employee = new Employee("Mariusz", "Kowalski");
employee.AddGrade(4);
employee.AddGrade(5);
employee.AddGrade(3);

var statistics = employee.GetStatisticsWitchForEach();
Console.WriteLine($"Dla pętli ForEach:");
Console.WriteLine($"Average = {statistics.Average:N2}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Max = {statistics.Max}");

var statistics1 = employee.GetStatisticsWitchWhile();
Console.WriteLine($"Dla pętli While:");
Console.WriteLine($"Average = {statistics1.Average:N2}");
Console.WriteLine($"Min = {statistics1.Min}");
Console.WriteLine($"Max = {statistics1.Max}");

var statistics2 = employee.GetStatisticsWitchFor();
Console.WriteLine($"Dla pętli For:");
Console.WriteLine($"Average = {statistics2.Average:N2}");
Console.WriteLine($"Min = {statistics2.Min}");
Console.WriteLine($"Max = {statistics2.Max}");

var statistics3 = employee.GetStatisticsWitchDoWhile();
Console.WriteLine($"Dla pętli DoWhile:");
Console.WriteLine($"Average = {statistics3.Average:N2}");
Console.WriteLine($"Min = {statistics3.Min}");
Console.WriteLine($"Max = {statistics3.Max}");

﻿using New1;

var employee = new Employee("Mariusz", "Grabowski");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(3);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average = {statistics.Average:N2}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Max = {statistics.Max}");
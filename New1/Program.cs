using New1;
using System;

Console.WriteLine(" Witaj w programie XYZ");
Console.WriteLine("=======================");
Console.WriteLine();


var employee = new Employee("Mariusz", "Kowalski");
while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q") 
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average for : {employee.Name} {employee.Surname} to {statistics.Average}");
Console.WriteLine($"Min for: {employee.Name} {employee.Surname} to {statistics.Min}");
Console.WriteLine($"Max: {employee.Name} {employee.Surname} to {statistics.Max}");





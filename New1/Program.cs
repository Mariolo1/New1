using New1;
using System;

Console.WriteLine(" Witaj w programie do oceny pracownika XYZ");
Console.WriteLine("==========================================");
Console.WriteLine("Wprowadź ocene pracownika w skali od 0 do 100 punktów");
Console.WriteLine("Finalnie pracownik otrzyma ocenę w skali literowej od A do E gdzie A jest najwyższa a E najniższa");
Console.WriteLine("Zakończ wprowadzanie danych wprowadzając litrę q");


var employee = new Employee("Mariusz", "Kowalski");
while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();

    if (input == "q") 
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception cached: {e.Message}");
    }
   
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average for : {employee.Name} {employee.Surname}\n to {statistics.Average:N2}");
Console.WriteLine($"Min for: {employee.Name} {employee.Surname}\n to {statistics.Min}");
Console.WriteLine($"Max for: {employee.Name} {employee.Surname}\n to {statistics.Max}");
Console.WriteLine($"Letter grade: {employee.Name} {employee.Surname}\n to {statistics.AverageLetter}");





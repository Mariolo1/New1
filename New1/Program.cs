using System.Globalization;

string input = Console.ReadLine();
var input1 = int.Parse(input);

string numberinstring = input1.ToString();
char[] letters = numberinstring.ToArray();

List<char> numbers = new List<char>();
numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');
foreach (var singular in numbers)
{
    int count = 0;
    foreach(var l in letters)

    {
        if (singular == l) count++;
    }
    Console.WriteLine(singular + ">" + count);


}



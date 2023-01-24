using New1;
using System.Runtime.CompilerServices;

Players player1 = new Players("Marek" ,"Kowalski ","34");
Players player2 = new Players("Marek", "Nowak ", "39");
Players player3 = new Players("Mirek", "Frankowski ", "44");


player1.AddScore(5);
player1.AddScore(9);
player1.AddScore(7);
player1.AddScore(8);
player1.AddScore(6);
// 35

player2.AddScore(5);
player2.AddScore(6);
player2.AddScore(4);
player2.AddScore(8);
player2.AddScore(5);
// 28

player3.AddScore(5);
player3.AddScore(1);
player3.AddScore(2);
player3.AddScore(4);
player3.AddScore(3);
// 15


if (player1.Result >= player2.Result && player1.Result >= player3.Result)
{
    Console.WriteLine($"Najwyższy wynik osiągnął ; { player1.Name}  { player1.Surname} wiek: {player1.Age}  jego wynik to:  {player1.Result}.");
}

else if (player2.Result >= player1.Result && player2.Result >= player3.Result)
{
    Console.WriteLine($"Najwyższy wynik osiągnął ; {player2.Name}  {player2.Surname} wiek: {player2.Age}  jego wynik to:  {player2.Result}.");
}

else if (player3.Result >= player1.Result && player3.Result >= player2.Result)
{
    Console.WriteLine($"Najwyższy wynik osiągnął ; {player3.Name}  {player3.Surname} wiek: {player3.Age}  jego wynik to:  {player3.Result}.");
}
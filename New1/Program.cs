using New1;
using System.Runtime.CompilerServices;

User user1 = new User("Mariolo" , "1234");
User user2 = new User("Monika" ,"1234");
User user3 = new User("Ola" ,"1234" );
User user4 = new User("Franek" , "1234" );

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);

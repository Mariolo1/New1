namespace New1.Tests
{
    public class TypeTest
    {
        [Test]
        public void Test2()
        {
            //arange
            int number1 = 4;
            int number2 = 2;

            //act

            //assert
            Assert.AreNotEqual(number1,number2);
            
        }

        [Test]
        public void Test()
        {
            //arange
            var player1 = GetPlayers("Adam");
            var player2 = GetPlayers("Piotr");

            //act
            var player3 = player1;

            //assert
            Assert.AreNotEqual(player1.Name, player2.Name);
            Assert.AreSame("Piotr", player2.Name);
            Assert.AreNotSame(player3, player2);
            
        }
        private Players GetPlayers(string name)
        {
            return new Players(name);
        }
    }
}

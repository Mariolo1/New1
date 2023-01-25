namespace New1.Tests
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            //arange
            var player = new Players("Marek", "Kowalski", "34");
            player.AddScore(7);
            player.AddScore(8);
            player.AddScore(-15);

            //act
            var result = player.Result;

            //assert
            Assert.AreEqual(0, result);
        }
    }
}
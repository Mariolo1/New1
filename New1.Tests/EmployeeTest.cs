namespace New1.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void Test()
        {
            //arange
            var employee = new Employee("Mariusz", "Frankowski");
            employee.AddGrade(44);
            employee.AddGrade(11);
            employee.AddGrade(17);


            //act
            var statistics = employee.GetStatistics();
            

            //assert
            Assert.AreEqual(44,statistics.Max );
            Assert.AreEqual(11,statistics.Min);
            Assert.AreEqual(24,statistics.Average);
            Assert.AreEqual('D', statistics.AverageLetter);
                       
        }
             
    }
}

namespace New1.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void Test()
        {
            //arange
            var employee = new Employee("Mariusz", "Frankowski");
            employee.AddGrade(22);
            employee.AddGrade(11);
            employee.AddGrade(9);


            //act
            var statistics = employee.GetStatistics();
            

            //assert
            Assert.AreEqual(22,statistics.Max );
            Assert.AreEqual(9,statistics.Min);
            Assert.AreEqual(14,statistics.Average);
                       
        }
             
    }
}

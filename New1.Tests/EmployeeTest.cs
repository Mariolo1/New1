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
            var result = statistics.Min;
            var result1 = statistics.Max;
            var result2 =  statistics.Average;

            //assert
            Assert.AreEqual(22,result1 );
            Assert.AreNotEqual(result, result1);
            Assert.AreNotEqual(result2, result);
                       
        }
             
    }
}

using System;
using Xunit;

namespace Assignment2.tests
{
    public class UnitTest1
    {
        [Fact]
        public void StudentTostringTest_featuring_Bob_Jones()
        {
            var student = new Student(0, "Bob", "Jones" new DateTime(2000, 01, 01), new DateTime(2005, 01, 01),new DateTime(2010, 01, 01));
            string expected = "Bob Jones, id: 0, status: Dropout, StartDate: 2000/01/01, EndDate: 2005/01/01, GraduationDate: 2010/01/01"
            Assert.Equal(expected, student.ToString);
        }
    }
}

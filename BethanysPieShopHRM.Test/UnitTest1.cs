using BethanysPieShopHRM.HR;

namespace BethanysPieShopHRM.Test
{
    public class EmployeeTests
    {
        [Fact]
        public void PerfomWork_Adds_NumbersOfHours()
        {
            // Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            int numbersOfHours = 3;
            // Act
            employee.PerformWork(numbersOfHours);
            // Assert
            Assert.Equal(numbersOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerfomWork_Adds_NumbersOfHours_IfNoValueSpecified()
        {
            // Arrange
            Employee employee = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            
            // Act
            employee.PerformWork();
            // Assert
            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}
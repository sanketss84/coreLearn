using FizzWare.NBuilder;
using System;
using System.Linq;
using Xunit;


namespace coreLearn.Library.xUnitTests
{
    //https://github.com/nbuilder/nbuilder
    //https://www.jerriepelser.com/blog/creating-test-data-with-nbuilder-and-faker/
    //http://www.dotnetfunda.com/articles/show/3418/generating-mock-data-using-nbuilder

    public class NBuilderDemo
    {
        [Fact]
        public void PassingTest()
        {
            var employee = Builder<Employee>
                .CreateNew()
                .Build();

            var employees = Builder<Employee>
                .CreateListOfSize(10)
                .Build();
            var employeeCount = employees.Count;

            Assert.NotNull(employee);
            Assert.Equal(10,employeeCount);

        }

        [Fact]
        public void Builder_GenerateRandomTestData()
        {
            var employees = Builder<Employee>
                 .CreateListOfSize(10)
                 .All()
                 .With(w => w.Email = GenerateEmailAddress())
                 .And(w => w.Gender = GenerateGender())
                 .Build()
                 .ToList();

            var employeeCount = employees.Count;

            Assert.Equal(10, employeeCount);

        }

        private static Random _random = new Random();
        public static string GenerateEmailAddress()
        {
            return $"{string.Join("", Enumerable.Repeat("abcdefABCDEF", 2).Select(s => s[_random.Next(s.Length)]))}@test.com";
        }

        public static string GenerateGender()
        {
            var gender = _random.Next(1, 9) % 2 == 0 ? "Male" : "Famale";
            return $"{gender}";
        }

    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
    }
}

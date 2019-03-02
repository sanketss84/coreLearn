using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using coreLearn.Protocol;

namespace coreLearn.Library.Shouldy
{
    [TestClass]
    public class ShouldlyDemo    
    {
        // http://docs.shouldly-lib.net/docs/
        // https://shouldly.readthedocs.io/en/latest/
        // https://visualstudiomagazine.com/articles/2015/08/01/improve-test-asserts-with-shouldly.aspx

        [TestMethod]
        public void ShouldBeOneOf()
        {
            var apu = new Person() { Name = "Apu" };
            var homer = new Person() { Name = "Homer" };
            var skinner = new Person() { Name = "Skinner" };
            var barney = new Person() { Name = "Barney" };
            var theBeSharps = new List<Person>() { homer, skinner, barney, apu };

            apu.ShouldBeOneOf(theBeSharps.ToArray());
        }

        [TestMethod]
        public void ShouldNotBeOneOf()
        {
            var apu = new Person() { Name = "Apu" };
            var homer = new Person() { Name = "Homer" };
            var skinner = new Person() { Name = "Skinner" };
            var barney = new Person() { Name = "Barney" };
            var wiggum = new Person() { Name = "Wiggum" };
            var theBeSharps = new List<Person>() { apu, homer, skinner, barney };

            wiggum.ShouldNotBeOneOf(theBeSharps.ToArray());
        }

        [TestMethod]
        public void DemoTestMethod()
        {
            var value = 5;
            value.ShouldBe(5);
            value.ShouldBeGreaterThan(4);
            value.ShouldBeGreaterThanOrEqualTo(5);
            value.ShouldBeInRange(0, 10);
            value.ShouldBeLessThan(6);
            value.ShouldBeOneOf(2, 5, 7);
        }

    }

    // public class Person
    // {
    //     public string Name { get; set; }
    // }
}

using FizzWare.NBuilder;
using System;
using System.Linq;
using Xunit;
using Faker;
using coreLearn.Protocol;

namespace coreLearn.Library.xUnitTests
{

    public class NBuilderFakerDemo
    {
        // https://www.jerriepelser.com/blog/creating-test-data-with-nbuilder-and-faker/

        [Fact]
        public void PassingTest()
        {
            var customers = Builder<Customer>.CreateListOfSize(100).Build();

            var customersFaker = Builder<Customer>.CreateListOfSize(100)
                                .All()
                                    .With(c => c.FirstName = Faker.Name.First())
                                    .With(c => c.LastName = Faker.Name.Last())
                                    .With(c => c.EmailAddress = Faker.Internet.Email())
                                    .With(c => c.TelephoneNumber = Faker.Phone.Number())
                                .Build();

            // Generate products
            var priceGenerator = new RandomGenerator();

            var products = Builder<Product>.CreateListOfSize(50)
                .All()
                    .With(p => p.Name = "Product " + p.Id.ToString())
                    .With(p => p.Description = Faker.Lorem.Paragraph())
                    .With(p => p.Price = priceGenerator.Next(50, 500))
                .Build();

            // Generate the orders
            var daysGenerator = new RandomGenerator();

            var orders = Builder<Order>.CreateListOfSize(200)
                .All()
                    .With(o => o.Customer = Pick<Customer>.RandomItemFrom(customers))
                    .With(o => o.OrderDate = DateTime.Now.AddDays(-daysGenerator.Next(1, 100)))
                .Build();


        }
    }

}

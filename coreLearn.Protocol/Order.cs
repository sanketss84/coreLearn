using System;

namespace coreLearn.Protocol
{
    public class Order
    {
        public Customer Customer { get; set; }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
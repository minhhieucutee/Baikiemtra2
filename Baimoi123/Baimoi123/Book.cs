

using System;

namespace Baimoi123

{
    class Book : Product
    {
        public Book(string productId, string name, double price, string producer)
            : base(productId, name, price, producer)
        {

        }

        public double Price { get; private set; }

        public override double ComputeTax()
        {
            return Price * 0.08;
        }
    }
}
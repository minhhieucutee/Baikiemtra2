using System;

namespace Baimoi123
{
    class MobilePhone : Product
    {
        public MobilePhone(string productId, string name, double price, string producer)
            : base(productId, name, price, producer)
        {
        }

        public override double ComputeTax()
        {
            return Price * 0.1;
        }
    }

}
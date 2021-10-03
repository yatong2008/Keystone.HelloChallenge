namespace Keystone.HelloChallenge.Support.QuickShip
{
    public sealed class ShippingPrice
    {
        public ShippingPrice(string shippingClass, decimal price)
        {
            ShippingClass = shippingClass;
            Price = price;
        }

        public string ShippingClass { get; }
        public decimal Price { get; }
    }
}

namespace Keystone.HelloChallenge.Support.SendIt
{
    public sealed class ShippingRate
    {
        public ShippingRate(
            string rateCode,
            double minCubicWeight,
            double maxCubicWeight,
            decimal maxParcelValue,
            decimal pricePerUnitWeight,
            decimal pricePerUnitValue)
        {
            RateCode = rateCode;
            MinCubicWeight = minCubicWeight;
            MaxCubicWeight = maxCubicWeight;
            MaxParcelValue = maxParcelValue;
            PricePerUnitWeight = pricePerUnitWeight;
            PricePerUnitValue = pricePerUnitValue;
        }

        public string RateCode { get; }
        public double MinCubicWeight { get; }
        public double MaxCubicWeight { get; }
        public decimal MaxParcelValue { get; }
        public decimal PricePerUnitWeight { get; }
        public decimal PricePerUnitValue { get; }
    }
}

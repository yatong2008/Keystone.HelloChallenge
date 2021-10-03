using System.Collections.Generic;
using System.Linq;

namespace Keystone.HelloChallenge.Models
{
    internal class Shipment
    {
        public Shipment(string code, IEnumerable<ShipmentLine> shipmentLines) => (Code, ShipmentLines) = (code, shipmentLines.ToList());

        public string Code { get; }
        public IReadOnlyList<ShipmentLine> ShipmentLines { get; }
    }

    internal class ShipmentLine
    {
        public ShipmentLine(
            int lineNumber,
            string itemCode,
            double cubicWeight,
            decimal declaredValue)
        {
            LineNumber = lineNumber;
            ItemCode = itemCode;
            CubicWeight = cubicWeight;
            DeclaredValue = declaredValue;
        }

        public int LineNumber { get; set;}
        public string ItemCode { get; set;}
        public double CubicWeight { get; set;}
        public decimal DeclaredValue { get; set;}
    }

    internal class Carrier
    {
        public Carrier(string name, string rateCode, decimal price) => (Name, RateCode, Price) = (name, rateCode, price);

        public string Name { get; set; }
        public string RateCode { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, RateCode = {RateCode}, Price = {Price}";
        }
    }
}

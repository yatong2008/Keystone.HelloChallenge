using Keystone.HelloChallenge.Models;
using System.Collections.Generic;

namespace Keystone.HelloChallenge.Data
{
    internal static class SampleShipments
    {
        private static readonly IEnumerable<Shipment> s_shipments = new[]
        {
            new Shipment("DFLLCI", new[]
            {
                new ShipmentLine(1, "INC-3102",  0.45,  55.90m),
            }),
            new Shipment("PBEQHH", new[]
            {
                new ShipmentLine(1, "PHX-4338", 80.50, 299.00m),
                new ShipmentLine(2, "XKT-1644", 78.50, 106.99m),
                new ShipmentLine(3, "VEH-5031", 54.50, 340.65m),
                new ShipmentLine(4, "NGB-8783", 83.00, 155.89m),
            }),
            new Shipment("PWCXIX", new[]
            {
                new ShipmentLine(1, "DDZ-1002",  1.00,  47.50m),
            }),
            new Shipment("TURNBL", new[]
            {
                new ShipmentLine(1, "HKT-5232",  3.25, 124.55m),
            }),
            new Shipment("ENCMPV", new[]
            {
                new ShipmentLine(1, "TEU-2685", 88.80,  26.05m),
                new ShipmentLine(2, "JOW-4535", 75.25, 227.95m),
                new ShipmentLine(3, "AUQ-4072", 99.90,   7.95m),
                new ShipmentLine(4, "UNO-8104", 17.75, 347.20m),
                new ShipmentLine(5, "NBM-4131", 80.75, 289.40m),
                new ShipmentLine(6, "ALW-4550", 68.10, 306.81m),
                new ShipmentLine(7, "TSI-4852", 35.50, 114.20m),
                new ShipmentLine(8, "DGR-2108", 49.50, 298.95m),
                new ShipmentLine(9, "PGG-5707", 74.75, 337.00m)
            }),
            new Shipment("OOBLCE", new[]
            {
                new ShipmentLine(1, "GTL-2427", 21.40,   5.22m),
            }),
            new Shipment("YXEXAL", new[]
            {
                new ShipmentLine(1, "PBC-4560", 79.75,  96.60m),
                new ShipmentLine(2, "BIO-6770",  4.50, 169.44m),
                new ShipmentLine(3, "BWO-4356", 56.50, 418.30m),
            }),
            new Shipment("GGTLHK", new[]
            {
                new ShipmentLine(1, "XFQ-2720", 70.50,   8.75m),
            }),
            new Shipment("FJUELF", new[]
            {
                new ShipmentLine(1, "KPI-2862",  2.25,   3.50m),
            }),
            new Shipment("DQWBUA", new[]
            {
                new ShipmentLine(1, "NFC-7758", 95.25, 288.40m),
                new ShipmentLine(2, "SEF-3042", 45.70, 364.80m),
                new ShipmentLine(3, "UMY-6817", 29.55, 146.30m),
                new ShipmentLine(4, "WEG-1241", 59.80, 484.40m),
                new ShipmentLine(5, "KIQ-7022", 31.90,  97.00m),
                new ShipmentLine(6, "HXX-2383", 99.40, 303.89m),
            }),
            new Shipment("PHBMJO", new[]
            {
                new ShipmentLine(1, "EAV-2212", 55.25,  20.00m),
            }),
            new Shipment("UDNMQB", new[]
            {
                new ShipmentLine(1, "PHW-2265", 54.55,  15.45m),
                new ShipmentLine(2, "SMB-6088", 46.15, 455.40m),
                new ShipmentLine(3, "EYJ-1221", 79.20, 408.00m),
                new ShipmentLine(4, "KWN-5362", 82.85, 237.35m),
            }),
        };

        public static IEnumerable<Shipment> Get() => s_shipments;
    }
}

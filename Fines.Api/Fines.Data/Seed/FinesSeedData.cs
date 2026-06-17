using Fines.Core.Enums;
using Fines.Data.Models;

namespace Fines.Data.Seed;

public static class FinesSeedData
{
    public static List<FinesEntity> GetSeedData()
    {
        return new List<FinesEntity>
        {
            // Speeding Fines (F001-F005)
            new FinesEntity
            {
                Id = 1,
                FineNo = "F001",
                FineDate = new DateTime(2026, 3, 15),
                FineType = FineType.Speeding,
                VehicleDriverName = "Michael Johnson",
                VehicleId = 1,
                CustomerId = 1
            },
            new FinesEntity
            {
                Id = 2,
                FineNo = "F002",
                FineDate = new DateTime(2026, 5, 22),
                FineType = FineType.Speeding,
                VehicleDriverName = "Sarah Williams",
                VehicleId = 2,
                CustomerId = 2
            },
            new FinesEntity
            {
                Id = 3,
                FineNo = "F003",
                FineDate = new DateTime(2026, 7, 8),
                FineType = FineType.Speeding,
                VehicleDriverName = "Jennifer Brown",
                VehicleId = 3,
                CustomerId = 3
            },
            new FinesEntity
            {
                Id = 4,
                FineNo = "F004",
                FineDate = new DateTime(2026, 9, 14),
                FineType = FineType.Speeding,
                VehicleDriverName = "Emma Garcia",
                VehicleId = 4,
                CustomerId = 4
            },
            new FinesEntity
            {
                Id = 5,
                FineNo = "F005",
                FineDate = new DateTime(2026, 11, 29),
                FineType = FineType.Speeding,
                VehicleDriverName = "Robert Martinez",
                VehicleId = 5,
                CustomerId = 5
            },

            // Parking Fines (F006-F010)
            new FinesEntity
            {
                Id = 6,
                FineNo = "F006",
                FineDate = new DateTime(2026, 2, 10),
                FineType = FineType.Parking,
                VehicleDriverName = "Lisa Anderson",
                VehicleId = 6,
                CustomerId = 6,
            },
            new FinesEntity
            {
                Id = 7,
                FineNo = "F007",
                FineDate = new DateTime(2026, 4, 17),
                FineType = FineType.Parking,
                VehicleDriverName = "James Wilson",
                VehicleId = 7,
                CustomerId = 7,
            },
            new FinesEntity
            {
                Id = 8,
                FineNo = "F008",
                FineDate = new DateTime(2026, 6, 25),
                FineType = FineType.Parking,
                VehicleDriverName = "Thomas Thompson",
                VehicleId = 8,
                CustomerId = 8,
            },
            new FinesEntity
            {
                Id = 9,
                FineNo = "F009",
                FineDate = new DateTime(2026, 8, 3),
                FineType = FineType.Parking,
                VehicleDriverName = "William Davis",
                VehicleId = 9,
                CustomerId = 9,
            },
            new FinesEntity
            {
                Id = 10,
                FineNo = "F010",
                FineDate = new DateTime(2026, 10, 19),
                FineType = FineType.Parking,
                VehicleDriverName = "Jennifer Rodriguez",
                VehicleId = 10,
                CustomerId = 10,
            },

            // Red Light Violation Fines (F011-F015)
            new FinesEntity
            {
                Id = 11,
                FineNo = "F011",
                FineDate = new DateTime(2026, 1, 28),
                FineType = FineType.RedLightViolation,
                VehicleDriverName = "Richard Lee",
                VehicleId = 11,
                CustomerId = 11,
            },
            new FinesEntity
            {
                Id = 12,
                FineNo = "F012",
                FineDate = new DateTime(2026, 3, 30),
                FineType = FineType.RedLightViolation,
                VehicleDriverName = "Linda Harris",
                VehicleId = 12,
                CustomerId = 12,
            },
            new FinesEntity
            {
                Id = 13,
                FineNo = "F013",
                FineDate = new DateTime(2026, 5, 12),
                FineType = FineType.RedLightViolation,
                VehicleDriverName = "Patricia Clark",
                VehicleId = 13,
                CustomerId = 13,
            },
            new FinesEntity
            {
                Id = 14,
                FineNo = "F014",
                FineDate = new DateTime(2026, 7, 21),
                FineType = FineType.RedLightViolation,
                VehicleDriverName = "Patricia Walker",
                VehicleId = 14,
                CustomerId = 14,
            },
            new FinesEntity
            {
                Id = 15,
                FineNo = "F015",
                FineDate = new DateTime(2026, 9, 7),
                FineType = FineType.RedLightViolation,
                VehicleDriverName = "Daniel Lewis",
                VehicleId = 15,
                CustomerId = 15,
            },

            // No Insurance Fines (F016-F020)
            new FinesEntity
            {
                Id = 16,
                FineNo = "F016",
                FineDate = new DateTime(2026, 2, 14),
                FineType = FineType.NoInsurance,
                VehicleDriverName = "Elizabeth Hall",
                VehicleId = 16,
                CustomerId = 16,
            },
            new FinesEntity
            {
                Id = 17,
                FineNo = "F017",
                FineDate = new DateTime(2026, 4, 9),
                FineType = FineType.NoInsurance,
                VehicleDriverName = "Matthew Young",
                VehicleId = 17,
                CustomerId = 17,
            },
            new FinesEntity
            {
                Id = 18,
                FineNo = "F018",
                FineDate = new DateTime(2026, 6, 18),
                FineType = FineType.NoInsurance,
                VehicleDriverName = "Steven Allen",
                VehicleId = 18,
                CustomerId = 18,
            },
            new FinesEntity
            {
                Id = 19,
                FineNo = "F019",
                FineDate = new DateTime(2026, 8, 26),
                FineType = FineType.NoInsurance,
                VehicleDriverName = "Christopher King",
                VehicleId = 19,
                CustomerId = 19,
            },
            new FinesEntity
            {
                Id = 20,
                FineNo = "F020",
                FineDate = new DateTime(2026, 10, 11),
                FineType = FineType.NoInsurance,
                VehicleDriverName = "Susan Moore",
                VehicleId = 20,
                CustomerId = 20,
            },

            // Illegal Parking Fines (F021-F025)
            new FinesEntity
            {
                Id = 21,
                FineNo = "F021",
                FineDate = new DateTime(2026, 1, 19),
                FineType = FineType.SeatBeltViolation,
                VehicleDriverName = "Andrew Martin",
                VehicleId = 21,
                CustomerId = 21,
            },
            new FinesEntity
            {
                Id = 22,
                FineNo = "F022",
                FineDate = new DateTime(2026, 3, 27),
                FineType = FineType.SeatBeltViolation,
                VehicleDriverName = "Jessica Taylor",
                VehicleId = 22,
                CustomerId = 22,
            },
            new FinesEntity
            {
                Id = 23,
                FineNo = "F023",
                FineDate = new DateTime(2026, 5, 5),
                FineType = FineType.SeatBeltViolation,
                VehicleDriverName = "Emily Jackson",
                VehicleId = 23,
                CustomerId = 23
            },
            new FinesEntity
            {
                Id = 24,
                FineNo = "F024",
                FineDate = new DateTime(2026, 7, 16),
                FineType = FineType.SeatBeltViolation,
                VehicleDriverName = "Emily White",
                VehicleId = 24,
                CustomerId = 24
            },
            new FinesEntity
            {
                Id = 25,
                FineNo = "F025",
                FineDate = new DateTime(2026, 9, 23),
                FineType = FineType.SeatBeltViolation,
                VehicleDriverName = "Paul Lopez",
                VehicleId = 25,
                CustomerId = 25
            }
        };
    }
}
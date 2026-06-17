using Fines.Data.Models;

namespace Fines.Data.Seed;

public static class VehicleSeedData
{
    public static List<VehicleEntity> GetSeedData()
    {
        return new List<VehicleEntity>
        {
            new VehicleEntity
            {
                Id = 1,
                RegistrationNumber = "ABC123",
                Make = "Ford",
                Model = "Focus",
                Color = "Blue",
                Year = 2019,
                VinNumber = "1HGBH41JXMN109186",
                EngineSize = "1.6L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2019, 3, 15),
                InsuranceExpiryDate = new DateTime(2027, 3, 15),
                MotExpiryDate = new DateTime(2027, 3, 14)
            },
            new VehicleEntity
            {
                Id = 2,
                RegistrationNumber = "XYZ789",
                Make = "Volkswagen",
                Model = "Golf",
                Color = "Silver",
                Year = 2020,
                VinNumber = "2HGBH41JXMN109187",
                EngineSize = "2.0L",
                FuelType = "Diesel",
                RegistrationDate = new DateTime(2020, 5, 20),
                InsuranceExpiryDate = new DateTime(2027, 5, 20),
                MotExpiryDate = new DateTime(2027, 5, 19)
            },
            new VehicleEntity
            {
                Id = 3,
                RegistrationNumber = "DEF456",
                Make = "BMW",
                Model = "3 Series",
                Color = "Black",
                Year = 2021,
                VinNumber = "3HGBH41JXMN109188",
                EngineSize = "2.0L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2021, 7, 10),
                InsuranceExpiryDate = new DateTime(2027, 7, 10),
                MotExpiryDate = new DateTime(2027, 7, 9)
            },
            new VehicleEntity
            {
                Id = 4,
                RegistrationNumber = "GHI321",
                Make = "Toyota",
                Model = "Corolla",
                Color = "White",
                Year = 2018,
                VinNumber = "4HGBH41JXMN109189",
                EngineSize = "1.8L",
                FuelType = "Hybrid",
                RegistrationDate = new DateTime(2018, 9, 5),
                InsuranceExpiryDate = new DateTime(2027, 9, 5),
                MotExpiryDate = new DateTime(2027, 9, 4)
            },
            new VehicleEntity
            {
                Id = 5,
                RegistrationNumber = "JKL654",
                Make = "Audi",
                Model = "A4",
                Color = "Grey",
                Year = 2022,
                VinNumber = "5HGBH41JXMN109190",
                EngineSize = "2.0L",
                FuelType = "Diesel",
                RegistrationDate = new DateTime(2022, 11, 25),
                InsuranceExpiryDate = new DateTime(2027, 11, 25),
                MotExpiryDate = new DateTime(2027, 11, 24)
            },
            new VehicleEntity
            {
                Id = 6,
                RegistrationNumber = "MNO987",
                Make = "Mercedes-Benz",
                Model = "C-Class",
                Color = "Silver",
                Year = 2020,
                VinNumber = "6HGBH41JXMN109191",
                EngineSize = "2.0L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2020, 2, 8),
                InsuranceExpiryDate = new DateTime(2027, 2, 8),
                MotExpiryDate = new DateTime(2027, 2, 7)
            },
            new VehicleEntity
            {
                Id = 7,
                RegistrationNumber = "PQR246",
                Make = "Honda",
                Model = "Civic",
                Color = "Red",
                Year = 2019,
                VinNumber = "7HGBH41JXMN109192",
                EngineSize = "1.5L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2019, 4, 12),
                InsuranceExpiryDate = new DateTime(2027, 4, 12),
                MotExpiryDate = new DateTime(2027, 4, 11)
            },
            new VehicleEntity
            {
                Id = 8,
                RegistrationNumber = "STU135",
                Make = "Nissan",
                Model = "Qashqai",
                Color = "Blue",
                Year = 2021,
                VinNumber = "8HGBH41JXMN109193",
                EngineSize = "1.3L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2021, 6, 18),
                InsuranceExpiryDate = new DateTime(2027, 6, 18),
                MotExpiryDate = new DateTime(2027, 6, 17)
            },
            new VehicleEntity
            {
                Id = 9,
                RegistrationNumber = "VWX802",
                Make = "Vauxhall",
                Model = "Astra",
                Color = "White",
                Year = 2018,
                VinNumber = "9HGBH41JXMN109194",
                EngineSize = "1.4L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2018, 8, 1),
                InsuranceExpiryDate = new DateTime(2027, 8, 1),
                MotExpiryDate = new DateTime(2027, 7, 31)
            },
            new VehicleEntity
            {
                Id = 10,
                RegistrationNumber = "YZA579",
                Make = "Hyundai",
                Model = "Tucson",
                Color = "Black",
                Year = 2022,
                VinNumber = "AHGBH41JXMN109195",
                EngineSize = "1.6L",
                FuelType = "Hybrid",
                RegistrationDate = new DateTime(2022, 10, 15),
                InsuranceExpiryDate = new DateTime(2027, 10, 15),
                MotExpiryDate = new DateTime(2027, 10, 14)
            },
            new VehicleEntity
            {
                Id = 11,
                RegistrationNumber = "BCD147",
                Make = "Mazda",
                Model = "3",
                Color = "Red",
                Year = 2020,
                VinNumber = "BHGBH41JXMN109196",
                EngineSize = "2.0L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2020, 1, 20),
                InsuranceExpiryDate = new DateTime(2027, 1, 20),
                MotExpiryDate = new DateTime(2027, 1, 19)
            },
            new VehicleEntity
            {
                Id = 12,
                RegistrationNumber = "EFG258",
                Make = "Kia",
                Model = "Sportage",
                Color = "Grey",
                Year = 2021,
                VinNumber = "CHGBH41JXMN109197",
                EngineSize = "1.6L",
                FuelType = "Diesel",
                RegistrationDate = new DateTime(2021, 3, 25),
                InsuranceExpiryDate = new DateTime(2027, 3, 25),
                MotExpiryDate = new DateTime(2027, 3, 24)
            },
            new VehicleEntity
            {
                Id = 13,
                RegistrationNumber = "HIJ369",
                Make = "Peugeot",
                Model = "308",
                Color = "Blue",
                Year = 2019,
                VinNumber = "DHGBH41JXMN109198",
                EngineSize = "1.5L",
                FuelType = "Diesel",
                RegistrationDate = new DateTime(2019, 5, 8),
                InsuranceExpiryDate = new DateTime(2027, 5, 8),
                MotExpiryDate = new DateTime(2027, 5, 7)
            },
            new VehicleEntity
            {
                Id = 14,
                RegistrationNumber = "KLM741",
                Make = "Renault",
                Model = "Megane",
                Color = "Silver",
                Year = 2020,
                VinNumber = "EHGBH41JXMN109199",
                EngineSize = "1.3L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2020, 7, 16),
                InsuranceExpiryDate = new DateTime(2027, 7, 16),
                MotExpiryDate = new DateTime(2027, 7, 15)
            },
            new VehicleEntity
            {
                Id = 15,
                RegistrationNumber = "NOP852",
                Make = "Seat",
                Model = "Leon",
                Color = "White",
                Year = 2021,
                VinNumber = "FHGBH41JXMN109200",
                EngineSize = "1.5L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2021, 9, 3),
                InsuranceExpiryDate = new DateTime(2027, 9, 3),
                MotExpiryDate = new DateTime(2027, 9, 2)
            },
            new VehicleEntity
            {
                Id = 16,
                RegistrationNumber = "QRS963",
                Make = "Skoda",
                Model = "Octavia",
                Color = "Black",
                Year = 2019,
                VinNumber = "GHGBH41JXMN109201",
                EngineSize = "1.4L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2019, 2, 10),
                InsuranceExpiryDate = new DateTime(2027, 2, 10),
                MotExpiryDate = new DateTime(2027, 2, 9)
            },
            new VehicleEntity
            {
                Id = 17,
                RegistrationNumber = "TUV159",
                Make = "Volvo",
                Model = "XC60",
                Color = "Grey",
                Year = 2022,
                VinNumber = "HHGBH41JXMN109202",
                EngineSize = "2.0L",
                FuelType = "Hybrid",
                RegistrationDate = new DateTime(2022, 4, 5),
                InsuranceExpiryDate = new DateTime(2027, 4, 5),
                MotExpiryDate = new DateTime(2027, 4, 4)
            },
            new VehicleEntity
            {
                Id = 18,
                RegistrationNumber = "WXY267",
                Make = "Jaguar",
                Model = "XE",
                Color = "Blue",
                Year = 2020,
                VinNumber = "IHGBH41JXMN109203",
                EngineSize = "2.0L",
                FuelType = "Diesel",
                RegistrationDate = new DateTime(2020, 6, 14),
                InsuranceExpiryDate = new DateTime(2027, 6, 14),
                MotExpiryDate = new DateTime(2027, 6, 13)
            },
            new VehicleEntity
            {
                Id = 19,
                RegistrationNumber = "ZAB378",
                Make = "Land Rover",
                Model = "Discovery Sport",
                Color = "Silver",
                Year = 2021,
                VinNumber = "JHGBH41JXMN109204",
                EngineSize = "2.0L",
                FuelType = "Diesel",
                RegistrationDate = new DateTime(2021, 8, 22),
                InsuranceExpiryDate = new DateTime(2027, 8, 22),
                MotExpiryDate = new DateTime(2027, 8, 21)
            },
            new VehicleEntity
            {
                Id = 20,
                RegistrationNumber = "CDE489",
                Make = "Mini",
                Model = "Cooper",
                Color = "Red",
                Year = 2019,
                VinNumber = "KHGBH41JXMN109205",
                EngineSize = "1.5L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2019, 10, 7),
                InsuranceExpiryDate = new DateTime(2027, 10, 7),
                MotExpiryDate = new DateTime(2027, 10, 6)
            },
            new VehicleEntity
            {
                Id = 21,
                RegistrationNumber = "FGH591",
                Make = "Fiat",
                Model = "500",
                Color = "White",
                Year = 2020,
                VinNumber = "LHGBH41JXMN109206",
                EngineSize = "1.2L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2020, 1, 15),
                InsuranceExpiryDate = new DateTime(2027, 1, 15),
                MotExpiryDate = new DateTime(2027, 1, 14)
            },
            new VehicleEntity
            {
                Id = 22,
                RegistrationNumber = "IJK627",
                Make = "Citroen",
                Model = "C3",
                Color = "Black",
                Year = 2021,
                VinNumber = "MHGBH41JXMN109207",
                EngineSize = "1.2L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2021, 3, 23),
                InsuranceExpiryDate = new DateTime(2027, 3, 23),
                MotExpiryDate = new DateTime(2027, 3, 22)
            },
            new VehicleEntity
            {
                Id = 23,
                RegistrationNumber = "LMN738",
                Make = "Suzuki",
                Model = "Swift",
                Color = "Blue",
                Year = 2019,
                VinNumber = "NHGBH41JXMN109208",
                EngineSize = "1.0L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2019, 5, 1),
                InsuranceExpiryDate = new DateTime(2027, 5, 1),
                MotExpiryDate = new DateTime(2027, 4, 30)
            },
            new VehicleEntity
            {
                Id = 24,
                RegistrationNumber = "OPQ849",
                Make = "Dacia",
                Model = "Sandero",
                Color = "Grey",
                Year = 2020,
                VinNumber = "OHGBH41JXMN109209",
                EngineSize = "1.0L",
                FuelType = "Petrol",
                RegistrationDate = new DateTime(2020, 7, 12),
                InsuranceExpiryDate = new DateTime(2027, 7, 12),
                MotExpiryDate = new DateTime(2027, 7, 11)
            },
            new VehicleEntity
            {
                Id = 25,
                RegistrationNumber = "RST915",
                Make = "Tesla",
                Model = "Model 3",
                Color = "White",
                Year = 2022,
                VinNumber = "PHGBH41JXMN109210",
                EngineSize = "N/A",
                FuelType = "Electric",
                RegistrationDate = new DateTime(2022, 9, 19),
                InsuranceExpiryDate = new DateTime(2027, 9, 19),
                MotExpiryDate = new DateTime(2027, 9, 18)
            }
        };
    }
}

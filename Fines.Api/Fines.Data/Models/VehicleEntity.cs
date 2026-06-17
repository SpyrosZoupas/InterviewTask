namespace Fines.Data.Models;

public class VehicleEntity
{
    public int Id { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int Year { get; set; }
    public string VinNumber { get; set; } = string.Empty;
    public string EngineSize { get; set; } = string.Empty;
    public string FuelType { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; }
    public DateTime InsuranceExpiryDate { get; set; }
    public DateTime MotExpiryDate { get; set; }
}

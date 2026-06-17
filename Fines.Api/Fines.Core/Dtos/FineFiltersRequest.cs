using Fines.Core.Enums;

namespace Fines.Core.Dtos
{
    public class FineFiltersRequest
    {
        public string? FineType { get; set; }
        public string? VehicleRegNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

    }
}

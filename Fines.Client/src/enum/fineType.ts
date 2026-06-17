export enum FineType {
    Unknown = 0,
    Speeding = 1,
    Parking = 2,
    RedLightViolation = 3,
    NoInsurance = 4,
    SeatBeltViolation = 5
}

export const FineTypeLabels: Record<FineType, string> = {
    [FineType.Unknown]: "Unknown",
    [FineType.Speeding]: "Speeding",
    [FineType.Parking]: "Illegal Parking",
    [FineType.RedLightViolation]: "Red Light Violation",
    [FineType.NoInsurance]: "No Insurance",
    [FineType.SeatBeltViolation]: "Seat Belt Violation"
};
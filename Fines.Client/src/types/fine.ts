import { FineType } from "../enum/fineType";

export interface Fine {
  id: number;
  fineNo: string;
  fineDate: Date;
  fineType: FineType;
  vehicleRegNo: string;
  vehicleDriverName: string;
}

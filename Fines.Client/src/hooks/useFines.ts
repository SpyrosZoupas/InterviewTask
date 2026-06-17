import { useEffect, useState } from "react";
import { Fine } from "../types/fine";
import { Filters } from "../types/filters";

const API_URL = "https://localhost:7200/api";

export function useFines(filters?: Filters) {
  const [fines, setFines] = useState<Fine[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchFines = async () => {
      setLoading(true);
      setError(null);

      try {
        const { fineType, vehicleRegNo, fromDate, toDate } = filters || {};

        const url = new URL(`${API_URL}/fines`);
        const params = new URLSearchParams();
        if (fineType) params.set("fineType", fineType);
        if (vehicleRegNo) params.set("vehicleRegNo", vehicleRegNo);
        if (fromDate) params.set("fromDate", fromDate);
        if (toDate) params.set("toDate", toDate);

        url.search = params.toString();

        const response = await fetch(url.toString());

        if (!response.ok) {
          throw new Error(response.statusText);
        }

        const raw = await response.json();
        const fines = raw.map((fine: any) => ({
          ...fine,
          fineDate: new Date(fine.fineDate)
        }));

        setFines(fines);
      } catch (err) {
        console.error(err);
        setError("Failed to fetch fines");
      } finally {
        setLoading(false);
      }
    };

    fetchFines();
    // re-run when any filter primitive changes
  }, [filters?.fineType, filters?.vehicleRegNo, filters?.fromDate, filters?.toDate]);

  return { fines, loading, error };
}

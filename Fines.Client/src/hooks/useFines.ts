import { useEffect, useState } from "react";
import { Fine } from "../types/fine";

const API_URL = "http://localhost:5200/api";

export function useFines() {
  const [fines, setFines] = useState<Fine[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchFines = async () => {
      setLoading(true);
      setError(null);

      try {
        const response = await fetch(`${API_URL}/fines`);

        if (!response.ok) {
          throw new Error(response.statusText);
        }

        const raw = await response.json();
        const fines = raw.map((fine: any) => ({
          ...fine,
          fineDate: new Date(fine.fineDate),
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
  }, []);

  return { fines, loading, error };
}

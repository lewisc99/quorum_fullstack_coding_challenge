import { BillSummary } from "../types/BillSummary";
import { apiClient } from "./apiClient"; // Assuming apiClient is in the same folder

export const getBillsSummary = async (
  showAlert: (
    message: string,
    type: "success" | "error" | "warning" | "info"
  ) => void
) => {
  return await apiClient<BillSummary[]>("/api/bills/summary", showAlert);
};

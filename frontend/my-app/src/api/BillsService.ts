import { BillSummary } from "../types/BillSummary";
import { apiClient } from "./apiClient";

export const getBillsSummary = async (
  showAlert: (
    message: string,
    type: "success" | "error" | "warning" | "info"
  ) => void
) => {
  return await apiClient<BillSummary[]>("/api/bills/summary", showAlert);
};

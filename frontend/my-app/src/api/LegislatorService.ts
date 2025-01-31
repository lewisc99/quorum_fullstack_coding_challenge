import { LegislatorVote } from "../types/LegislatorVote";
import { apiClient } from "./apiClient";

export const fetchLegislatorsVotes = async (
  showAlert: (
    message: string,
    type: "success" | "error" | "warning" | "info"
  ) => void
) => {
  return await apiClient<LegislatorVote[]>("/api/legislator/votes", showAlert);
};

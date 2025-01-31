import axios from "axios";

const API_URL = import.meta.env.VITE_API_URL;

type AlertType = "success" | "error" | "warning" | "info";

export const apiClient = async <T>(
  endpoint: string,
  showAlert: (message: string, type: AlertType) => void
): Promise<T | null> => {
  try {
    const response = await axios.get(`${API_URL}${endpoint}`);

    if (!response.data.status) {
      showAlert(response.data.message, "error");
      return null;
    }

    return response.data.data;
  } catch {
    showAlert("An error occurred while fetching data.", "error");
    return null;
  }
};

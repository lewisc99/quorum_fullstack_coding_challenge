import { useState, useCallback } from "react";
import Snackbar from "@mui/material/Snackbar";
import Alert from "@mui/material/Alert";

export const useAlert = () => {
  const [open, setOpen] = useState(false);
  const [message, setMessage] = useState("");
  const [variant, setVariant] = useState<
    "success" | "error" | "warning" | "info"
  >("info");

  const showAlert = useCallback(
    (msg: string, type: "success" | "error" | "warning" | "info") => {
      setMessage(msg);
      setVariant(type);
      setOpen(true);
    },
    []
  );

  const handleAlertClose = useCallback(() => {
    setOpen(false);
  }, []);

  const AlertComponent = () => (
    <Snackbar open={open} autoHideDuration={6000} onClose={handleAlertClose}>
      <Alert
        onClose={handleAlertClose}
        severity={variant}
        sx={{ width: "100%" }}>
        {message}
      </Alert>
    </Snackbar>
  );

  return { showAlert, AlertComponent };
};

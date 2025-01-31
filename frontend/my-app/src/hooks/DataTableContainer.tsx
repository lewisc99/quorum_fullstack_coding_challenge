import React, { useEffect, useState } from "react";
import { Container } from "@mui/material";
import { useAlert } from "./useAlert";

interface Props<T> {
  fetchData: (
    showAlert: (
      message: string,
      type: "success" | "error" | "warning" | "info"
    ) => void
  ) => Promise<T[] | null>;
  renderTable: (data: T[], loading: boolean) => React.ReactNode;
  dataType: string;
}

const DataTableContainer = <T,>({
  fetchData,
  renderTable,
  dataType
}: Props<T>) => {
  const [data, setData] = useState<T[]>([]);
  const [loading, setLoading] = useState(true);
  const { showAlert, AlertComponent } = useAlert();

  useEffect(() => {
    setLoading(true);
    fetchData(showAlert)
      .then((result) => setData(result || []))
      .catch(() => showAlert(`Failed to load ${dataType}.`, "error"))
      .finally(() => setLoading(false));
  }, [fetchData, showAlert, dataType]);

  return (
    <Container>
      {renderTable(data, loading)}
      <AlertComponent />
    </Container>
  );
};

export default DataTableContainer;

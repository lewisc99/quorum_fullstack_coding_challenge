import React from "react";
import BillSummaryTable from "../components/BillSummaryTable";
import { getBillsSummary } from "../api/BillsService";
import DataTableContainer from "../hooks/DataTableContainer";

const BillsSummary: React.FC = () => {
  return (
    <DataTableContainer
      fetchData={getBillsSummary}
      renderTable={(bills, loading) => (
        <BillSummaryTable bills={bills} loading={loading} />
      )}
      dataType="Bills"
    />
  );
};

export default BillsSummary;

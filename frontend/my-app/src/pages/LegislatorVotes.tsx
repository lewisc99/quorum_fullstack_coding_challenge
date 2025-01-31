import React from "react";
import LegislatorTable from "../components/LegislatorTable";
import { fetchLegislatorsVotes } from "../api/LegislatorService";
import DataTableContainer from "../hooks/DataTableContainer";

const LegislatorVotes: React.FC = () => {
  return (
    <DataTableContainer
      fetchData={fetchLegislatorsVotes}
      renderTable={(data, loading) => (
        <LegislatorTable data={data} loading={loading} />
      )}
      dataType="Legislators"
    />
  );
};

export default LegislatorVotes;

import React from "react";
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
  Typography,
  CircularProgress,
  TableRow as MuiTableRow,
  TableCell as MuiTableCell
} from "@mui/material";
import { LegislatorVote } from "../types/LegislatorVote";

interface Props {
  data: LegislatorVote[];
  loading: boolean;
}

const LegislatorTable: React.FC<Props> = ({ data, loading }) => {
  return (
    <TableContainer component={Paper}>
      <Typography variant="h6" sx={{ padding: 2 }}>
        Legislator Votes
      </Typography>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell>ID</TableCell>
            <TableCell>Legislator</TableCell>
            <TableCell>Supported Bills</TableCell>
            <TableCell>Opposed Bills</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {loading ? (
            <MuiTableRow>
              <MuiTableCell colSpan={4} align="center">
                <CircularProgress />
              </MuiTableCell>
            </MuiTableRow>
          ) : data.length > 0 ? (
            data.map((legislator) => (
              <TableRow key={legislator.legislatorId}>
                <TableCell>{legislator.legislatorId}</TableCell>
                <TableCell>{legislator.legislatorName}</TableCell>
                <TableCell>{legislator.supportedBills}</TableCell>
                <TableCell>{legislator.opposedBills}</TableCell>
              </TableRow>
            ))
          ) : (
            <MuiTableRow>
              <MuiTableCell colSpan={4} align="center">
                No legislators found.
              </MuiTableCell>
            </MuiTableRow>
          )}
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default LegislatorTable;

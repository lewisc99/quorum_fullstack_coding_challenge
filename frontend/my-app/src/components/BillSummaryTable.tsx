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
  Box
} from "@mui/material";
import { BillSummary } from "../types/BillSummary";

interface Props {
  bills: BillSummary[];
  loading: boolean;
}

const BillSummaryTable: React.FC<Props> = ({ bills, loading }) => {
  return (
    <TableContainer component={Paper}>
      <Typography variant="h6" sx={{ padding: 2 }}>
        Bill Voting Summary
      </Typography>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell>ID</TableCell>
            <TableCell>Bill</TableCell>
            <TableCell>Supporters</TableCell>
            <TableCell>Opposers</TableCell>
            <TableCell>Primary Sponsor</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {loading ? (
            <TableRow>
              <TableCell colSpan={5}>
                <Box
                  sx={{
                    display: "flex",
                    justifyContent: "center",
                    alignItems: "center",
                    height: "100px",
                    width: "100%"
                  }}>
                  <CircularProgress />
                </Box>
              </TableCell>
            </TableRow>
          ) : bills.length > 0 ? (
            bills.map((bill) => (
              <TableRow key={bill.id}>
                <TableCell>{bill.id}</TableCell>
                <TableCell>{bill.billTitle}</TableCell>
                <TableCell>{bill.supporters}</TableCell>
                <TableCell>{bill.opposers}</TableCell>
                <TableCell>{bill.primarySponsor}</TableCell>
              </TableRow>
            ))
          ) : (
            <TableRow>
              <TableCell colSpan={5} align="center">
                No bills found.
              </TableCell>
            </TableRow>
          )}
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default BillSummaryTable;

import {
  BrowserRouter as Router,
  Route,
  Routes,
  useNavigate
} from "react-router-dom";
import {
  Container,
  AppBar,
  Toolbar,
  Typography,
  Tabs,
  Tab,
  Box
} from "@mui/material";
import LegislatorVotes from "./pages/LegislatorVotes";
import BillsSummary from "./pages/BillsSummary";
import { useState } from "react";

function NavigationTabs() {
  const navigate = useNavigate();
  const [tabIndex, setTabIndex] = useState(0);

  const handleChange = (_: React.SyntheticEvent, newValue: number) => {
    setTabIndex(newValue);
    navigate(newValue === 0 ? "/legislator-votes" : "/bills-summary");
  };

  return (
    <Tabs value={tabIndex} onChange={handleChange} centered>
      <Tab label="Legislator Votes" />
      <Tab label="Bills Summary" />
    </Tabs>
  );
}

function App() {
  return (
    <Router>
      <AppBar position="static" sx={{ backgroundColor: "#1976d2" }}>
        <Toolbar>
          <Typography variant="h6" sx={{ flexGrow: 1 }}>
            Coding Challenge
          </Typography>
        </Toolbar>
      </AppBar>

      <Container maxWidth="md" sx={{ mt: 4 }}>
        <NavigationTabs />
        <Box sx={{ mt: 3 }}>
          <Routes>
            <Route path="/" element={<LegislatorVotes />} />
            <Route path="/legislator-votes" element={<LegislatorVotes />} />
            <Route path="/bills-summary" element={<BillsSummary />} />
          </Routes>
        </Box>
      </Container>
    </Router>
  );
}

export default App;


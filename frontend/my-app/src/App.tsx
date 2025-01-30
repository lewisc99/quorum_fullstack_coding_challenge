import "./App.css";
import { Typography, Button, Box, Container } from "@mui/material"; // Import Material UI components

function App() {
  return (
    <Container maxWidth="sm">
      <Box
        sx={{
          display: "flex",
          flexDirection: "column",
          alignItems: "center",
          mt: 4
        }}>
        <Typography variant="h4" component="h1" gutterBottom>
          Welcome to Material UI
        </Typography>
        <Button variant="contained">Hello World</Button>
      </Box>
    </Container>
  );
}

export default App;

import React from "react";
import logo from "./logo.svg";
import "./App.css";
import { Home } from "./pages/home";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import { Layout } from "./pages/layout";
import { Restaurantes } from "./pages/restaurantes";
import { NoPage } from "./pages/nopage";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<Home />} />
          <Route path="restaurantes" element={<Restaurantes />} />
          <Route path="*" element={<NoPage />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;

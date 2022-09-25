import axios from "axios";
import { useEffect, useState } from "react";
import { CreateRestaurante } from "../components/create-restaurante";

export const Restaurantes = () => {
  useEffect(() => {
    try {
      const response = axios.get("https://localhost:7285/api/Restaurante");
      console.log(response);
    } catch (error: any) {
      console.log(error);
    }
  }, []);

  return (
    <>
      <CreateRestaurante></CreateRestaurante>
    </>
  );
};

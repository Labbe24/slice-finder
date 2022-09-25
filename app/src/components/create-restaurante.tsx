import { useState } from "react";
import styled from "styled-components";

const StyledForm = styled.form`
  display: flex;
  flex-direction: column;
  margin: 10px 10px 10px 10px;
  input {
    max-width: 200px;
  }
`;

export const CreateRestaurante = () => {
  const [name, setName] = useState<string>("");
  const [street, setStreet] = useState<string>("");
  const [zip, setZip] = useState<number>();
  const [city, setCity] = useState<string>("");
  const [country, setCountry] = useState<string>("");

  const handleNameChanged = (event: any) => {
    setName(event.target.value);
  };

  const handleStreetChanged = (event: any) => {
    setStreet(event.target.value);
  };

  const handleZipChanged = (event: any) => {
    setZip(event.target.value);
  };

  const handleCityChanged = (event: any) => {
    setCity(event.target.value);
  };

  const handleCountryChanged = (event: any) => {
    setCountry(event.target.value);
  };

  const handleSubmit = (event: any) => {
    event.preventDefault();
  };

  return (
    <StyledForm onSubmit={handleSubmit}>
      <input
        type="text"
        value={name}
        placeholder="Name"
        onChange={handleNameChanged}
      ></input>

      <input
        type="text"
        value={street}
        placeholder="Street"
        onChange={handleStreetChanged}
      ></input>

      <input
        type="number"
        value={zip}
        placeholder="Zip"
        onChange={handleZipChanged}
      ></input>

      <input
        type="text"
        value={city}
        placeholder="City"
        onChange={handleCityChanged}
      ></input>

      <input
        type="text"
        value={country}
        placeholder="Country"
        onChange={handleCountryChanged}
      ></input>

      <input type="submit" value="Create"></input>
    </StyledForm>
  );
};

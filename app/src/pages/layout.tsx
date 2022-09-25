import React from "react";
import { Link, Outlet } from "react-router-dom";
import styled from "styled-components";

const TopNavWrapper = styled.section`
  background-color: black;
  overflow: hidden;
`;

const TopNavTab = styled.div`
  float: left;
  text-align: center;
  text-decoration: none;
  font-size: 20px;
  padding: 14px 16px;
  color: #f2f2f2;
  cursor: pointer;
  &:hover {
    background-color: #ddd;
    color: black;
  }
  &:active {
    background-color: grey;
    color: white;
  }
`;

export const Layout = () => {
  return (
    <React.Fragment>
      <TopNavWrapper>
        <Link to="/">
          <TopNavTab>Home</TopNavTab>
        </Link>

        <Link to="/restaurantes">
          <TopNavTab>Restaurantes</TopNavTab>
        </Link>
      </TopNavWrapper>
      <Outlet></Outlet>
    </React.Fragment>
  );
};

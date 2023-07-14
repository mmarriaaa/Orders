import React from 'react';
import './App.scss';
import { 
  BrowserRouter
} from "react-router-dom";
import Navigation from '../nav/Navigation';
import Layout from '../layout/Layout';

function App() {
  return (
    <BrowserRouter >
      <Navigation />
      <Layout />
    </BrowserRouter>
  );
}

export default App;

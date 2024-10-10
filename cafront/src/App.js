// src/App.js
import React from 'react';
import ProductList from './components/ProductList';
import CreateOrder from './components/CreateOrder';
import OrderHistory from './components/OrderHistory';

const App = () => {
  return (
      <div>
        <h1>Dunder Mifflin Paper Company</h1>
        <ProductList />
        <CreateOrder />
        <OrderHistory />
      </div>
  );
};

export default App;

import React from 'react';
import {Route, Routes} from "react-router-dom";
import HomePage from '../pages/HomePage';
import OrdersPage from '../pages/OrdersPage';

export default function Layout() {
    return (
        <Routes>
            <Route path="Home" element={<HomePage />} />
            <Route path="/" element={<HomePage />} />
            <Route path="Orders" element={<OrdersPage />} />
        </Routes>
    );
}
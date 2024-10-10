import React, { useEffect } from 'react';
import { useAtom } from 'jotai';
import { orderHistoryAtom } from '../atoms/orderAtom';

const OrderHistory = () => {
    const [orders, setOrders] = useAtom(orderHistoryAtom);

    useEffect(() => {
        fetch('http://localhost:5120/api/order/my-orders?customerId=1')  // Cambia el ID del cliente según sea necesario
            .then(response => response.json())
            .then(data => setOrders(data))
            .catch(error => console.error('Error fetching order history:', error));
    }, [setOrders]);

    return (
        <div>
            <h2>Your Order History</h2>
            {orders.length === 0 ? (
                <p>No orders found.</p>
            ) : (
                <ul>
                    {orders.map(order => (
                        <li key={order.id}>
                            Order #{order.id} - {new Date(order.orderDate).toLocaleDateString()}
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
};

export default OrderHistory;

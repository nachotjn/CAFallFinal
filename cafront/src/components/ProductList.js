import React, { useEffect } from 'react';
import axios from 'axios';
import { useAtom } from 'jotai';
import { orderItemsAtom } from '../atoms/orderAtoms';

const ProductList = () => {
    const [orderItems, setOrderItems] = useAtom(orderItemsAtom);
    const [products, setProducts] = React.useState([]);

    useEffect(() => {
        const fetchProducts = async () => {
            const response = await axios.get('/api/product');
            setProducts(response.data);
        };
        fetchProducts();
    }, []);

    const addToOrder = (product) => {
        setOrderItems([...orderItems, product]);
    };

    return (
        <div>
            <h2>Product List</h2>
            <ul>
                {products.map(product => (
                    <li key={product.id}>
                        {product.name} - ${product.price}
                        <button onClick={() => addToOrder(product)}>Add to Order</button>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default ProductList;

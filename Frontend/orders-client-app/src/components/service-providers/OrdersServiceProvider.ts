import { WEB_API_URL } from "../../GlobalConsts";
import IOrder from "./IOrder";

export async function getOrders() {
    let response = await fetch(`${WEB_API_URL}/Order/Get?from=0&offset=100`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        }
    });

    return await response.json();
}

export async function create(order: IOrder) {
    await fetch(`${WEB_API_URL}/Order/Create`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify(order)
    });
}
export default interface Order {
    id: Number,
    senderCity: string,
    senderAddress: string,
    recipientCity: string,
    recipientAddress: string,
    cargoWeight: Number,
    cargoPickupDate: Date
}
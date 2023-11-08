# Project Plan

## Overview
Create a Point of Sale (PoS) object-oriented GUI desktop application for a the Cracked Cup coffee shop.

## Goals


## Tasks
### GUI Pages
- Dashboard/home with metrics
    Daily sales, total gross sales, total orders
- Process Order
- Process Payment

The GUI will be designed in C# amd implemented using WPF with XAML.<br>
Data will be stored as text records in files and loaded as needed.
The application will be designed will be in CLI to prototype.

### Classes / Subclasses
#### Order Class:
- Fields:
    - itemsOrdered: List of items in the order.
    - quantity: Quantity of each item.
    - orderType: Type of order (In Store or Take Out).
    - orderNum: 
- Methods:
    - calculateTotalCost(): Calculates the total cost of the order.
    - addItem(): Adds an item to the order.
    - removeItem(): Removes an item from the order.

- In Store (Subclass of Order):
    - Fields:
        - tableNumber: The table number for in-store orders.
        - 

- Take Out (Subclass of Order):
    - No additional fields or methods for now, as it inherits from the Order class.
        - cupType: 
        - label:

#### Payment Class:
- Fields:
    - paymentMethod: Method of payment (Cash or Card).
    - amount: The amount paid.
- Methods:
    - processPayment(): Processes the payment.
    - generateReceipt(): Generates a receipt for the payment.

- Cash (Subclass of Payment):
    - change
    - No additional fields or methods for now, as it inherits from the Payment class.

- Card (Subclass of Payment):
    - cardNum
    - cardExp
    - 
    - No additional fields or methods for now, as it inherits from the Payment class.

#### Product Structure:
- Fields:
    - productName: Name of the product.
    - price: Price of the product.
    - description: Description of the product.
- Methods: 
    - Constructor

#### Transaction Structure:
- Fields:
    - orderDetails: Details of the order.
    - paymentDetails: Details of the payment.
    - timestamp: Timestamp of the transaction.
- Methods:
    - Constructor
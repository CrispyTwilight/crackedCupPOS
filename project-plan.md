# Project Plan

## Overview
Create a Point of Sale (PoS) object-oriented GUI desktop application for a the Cracked Cup coffee shop.

## Goals


## Tasks
### GUI Pages
- Dashboard/home with metrics
    Daily sales, inventory status, customer count
- Process Order
- Process Payment
- Manage Inventory
- Maintain Customer Records

The GUI will be designed in C# amd implemented using WPF with XAML.<br>
Data will be stored as text records in files and loaded as needed.

### Classes / Subclasses
#### Order Class:
- Fields:
    - itemsOrdered: List of items in the order.
    - quantity: Quantity of each item.
    - orderType: Type of order (In Store or Take Out).
- Methods:
    - calculateTotalCost(): Calculates the total cost of the order.
    - addItem(): Adds an item to the order.
    - removeItem(): Removes an item from the order.

- In Store (Subclass of Order):
    - Fields:
        - tableNumber: The table number for in-store orders.

- Take Out (Subclass of Order):
    - No additional fields or methods for now, as it inherits from the Order class.

#### Payment Class:
- Fields:
    - paymentMethod: Method of payment (Cash or Card).
    - amount: The amount paid.
- Methods:
    - processPayment(): Processes the payment.
    - generateReceipt(): Generates a receipt for the payment.

- Cash (Subclass of Payment):
    - No additional fields or methods for now, as it inherits from the Payment class.

- Card (Subclass of Payment):
    - No additional fields or methods for now, as it inherits from the Payment class.

#### Inventory Class:
- Fields: 
    - itemName: Name of the item.
    - quantity: Quantity of the item.
    - category: Category of the item (Food/Drink or Retail).
- Methods:
    - updateQuantity(): Updates the quantity of an item.
    - addNewItem(): Adds a new item to the inventory.
    - removeItem(): Removes an item from the inventory.

Food and Drink Items (Subclass of Inventory):
- No additional fields or methods for now, as it inherits from the Inventory class.

Retail Items (Subclass of Inventory):
- No additional fields or methods for now, as it inherits from the Inventory class.

#### Customer Class:
- Fields:
    - customerName: Name of the customer.
    - customerEmail: Email address of the customer.
    - customerPhone: Phone number of the customer.
- Methods: 
    - placeOrder(): Places an order.
    - makePayment(): Makes a payment.
    - updateDetails(): Updates customer details.

#### Product Structure:
- Fields:
    - productName: Name of the product.
    - price: Price of the product.
    - description: Description of the product.
- Methods: 
    - updateDetails(): Updates product details.
    - displayDetails(): Displays product details.

#### Transaction Structure:
- Fields:
    - orderDetails: Details of the order.
    - paymentDetails: Details of the payment.
    - timestamp: Timestamp of the transaction.
- Methods:
    - generateTransactionRecord(): Generates a transaction record.

#### Employee Structure:
- Fields:
    - employeeName: Name of the employee.
    - role: Role of the employee.
    - contactDetails: Contact details of the employee.
- Methods:
    - updateRole(): Updates the role of the employee.
    - updateContactDetails(): Updates employee contact details.

#### CustomerDetails Structure:
- Fields:
    - customerName: Name of the customer.
    - contactDetails: Contact details of the customer.
    - loyaltyPoints: Loyalty points of the customer.
- Methods:
    - updateDetails(): Updates customer details.
    - trackLoyaltyPoints(): Tracks customer loyalty points.

#### Inventory Structure:
- Fields:
    - itemName: Name of the item.
    - quantity: Quantity of the item.
    - category: Category of the item (Food/Drink or Retail).
- Methods:
    - updateQuantity(): Updates the quantity of an item.
    - addNewItem(): Adds a new item to the inventory.
    - removeItem(): Removes an item from the inventory.
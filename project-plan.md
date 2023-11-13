# Project Plan

## Overview
Create a Point of Sale (PoS) object-oriented GUI desktop application for a the Cracked Cup coffee shop.

## GUI Pages
- Dashboard/home with metrics
    Daily sales, total gross sales, total orders
- Process Order
- Process Payment

exitBtn
orderBtn
paymentBtn
refreshBtn

Payment:
saveTxBtn
printReceiptBtn
calcChangeBtn

changeDueLbl
totalLbl
subtotalLbl
amtPaidLbl
taxLbl


The GUI will be designed in Visual C# Windows Forms.<br>
Data will be stored as CSV records in files and loaded as needed.
The application will be designed will be as a C++ CLI  app to prototype.

## Classes / Subclasses
### Order Class:
- Fields:
    - orderID
	- orderType
	- orderStatus
	- orderQuantity
	- orderTotal
	- Vector to store orderProducts
- Methods:
    - calculateTotalCost()
    - addItem()
    - removeItem()

#### In Store (Subclass of Order):
- Fields:
    - customerName
    - tableNumber
- Methods:
    - Constructor
    - Getters/Setters

#### Take Out (Subclass of Order):
- Fields:
    - customerName
    - pickupTime
- Methods:
    - Constructor
    - Getters/Setters

### Product Structure:
- Fields:
    - productID;
	- productName;
	- productDescription;
	- productPrice;
	- productQuantity;
- Methods:
    - Constructor

### Payment Class:
- Fields:
    - Instance of transaction structure
- Methods:
    - Constructor
    - Destructor
    - Getters/Setters
    - processPayment()
    - processRefund()
    - printReceipt()
    - printRefundReceipt()

#### Cash (Subclass of Payment):
- Fields:
    - amountTendered
    - changeDue
- Methods:
    - Constructor
    - Getters/Setters

#### Card (Subclass of Payment):
- Fields: 
    - cardNumber
    - expiryDate
    - cardHolderName
    - CVV
- Methods:
    - Constructor
    - Getters/Setters

### Transaction Structure:
- Fields:
    - orderID
    - transactionID
    - paymentTypeCode
    - paymentStatusCode
    - transactionAmount
    - date
    - time
    - type
- Methods:
    - Constructor
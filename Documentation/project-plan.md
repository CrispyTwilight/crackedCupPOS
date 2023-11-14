# Project Plan
Auth: John O'Neal

## Overview
Create a Point of Sale (PoS) object-oriented GUI desktop application for a the Cracked Cup coffee shop. The GUI will be designed in Visual C# Windows Forms. Data will be stored as CSV records in files and loaded as needed. The application will be also be designed as a C++ CLI app to prototype.

## GUI Pages
- Home
- Order
- Payment
<hr>

### Home Page Controls:
- homeTitleLbl
- instructionLbl
- orderBtn
- paymentBtn
- exitBtn
<hr>

### Payment Page Controls:
#### paymentFrm
- paymentTitleLbl
<br><br>
- searchOrderBtn
- processPaymentBtn
- processRefundBtn
- printReceiptBtn
- saveTransactionBtn
- clearBtn
- exitBtn

#### orderDetailPanel
- orderIDLbl
- transactionIDLbl
- dateLbl
- timeLbl
<br><br>
- orderIDTb
- transactionIDTb
- dateTb
- timeTb

#### costDetailPanel
- subtotalLbl
- taxLbl
- totalLbl
<br><br>
- subtotalTb
- taxTb
- totalTb

#### cashGroupBox
- amountTenderedLbl
- changeDueLbl
<br><br>
- amountTenderedTb
- changeDueTb

#### cardGroupBox
- cardNumberLbl
- expiryDateLbl
- cardholderNameLbl
- cvvLbl
<br><br>
- cardNumberTb
- expiryDateTb
- cardholderNameTb
- cvvTb

#### pmtTypeGroupBox
- cashRdo
- cardRdo
<hr>

### Order Page Controls

<hr>



## Classes / Subclasses
### Order Superclass:
- Fields:
    - orderID
	- orderType
	- orderStatus
	- orderQuantity
	- orderTotal
	- Vector to store orderProducts
- Methods:
    - Constructor
    - calculateTotalCost
    - addItem
    - removeItem
<hr>

### In Store (Subclass of Order):
- Fields:
    - customerName
    - tableNumber
- Methods:
    - Constructor
    - setTableNum
    - setCustomerName
    - getTableNum
    - getCustomerName
<hr>

### Take Out (Subclass of Order):
- Fields:
    - customerName
    - pickupTime
- Methods:
    - Constructor
    - setPickupTime
    - setCustomerName
    - getPickupTime
    - getCustomerName
<hr>

### Product Structure:
- Fields:
    - productID;
	- productName;
	- productDescription;
	- productPrice;
	- productQuantity;
- Methods:
    - Constructor
<hr>

### Payment Superclass:
- Fields:
    - Instance of transaction structure
    - Constant Tax_RATE
- Methods:
    - Constructor
    - Destructor
    - getOrderID
    - getTransactionID
    - getPaymentTypeCode
    - getPaymentStatusCode
    - getSubtotal
    - getTax
    - getTotalCost
    - getDate
    - getTime
    - setOrderID
    - setTransactionID
    - setPaymentTypeCode
    - setPaymentStatusCode
    - setSubtotal
    - setTax
    - setTotalCost
    - setDate
    - setTime
    - processRefund
    - displayReceipt
    - writeTransactionToFile
    - readTransactionFromFile
    - searchTransactionByOrderID
<hr>

### Cash (Subclass of Payment):
- Fields:
    - amountTendered
    - changeDue
- Methods:
    - Constructor
    - getAmountTendered
    - getChangeDue
    - setAmountTendered
    - setChangeDue
    - processPayment
    - printReceipt (override)
    - writeTransactionToFile (override)
<hr>

### Card (Subclass of Payment):
- Fields: 
    - cardNumber
    - expiryDate
    - cardHolderName
    - CVV
- Methods:
    - Constructor
    - getCardNumber
    - getExpiryDate
    - getCardHolderName
    - getCVV
    - setCardNumber
    - setExpiryDate
    - setCardHolderName
    - setCVV
    - processPayment
    - printReceipt (override)
    - writeTransactionToFile (override)
<hr>

### Transaction Structure:
- Fields:
    - orderID
    - transactionID
    - paymentTypeCode
    - paymentStatusCode
    - subtotal
    - tax
    - totalCost
    - date
    - time
    - static nextOrderID
    - static nextTransactionID
- Methods:
    - Constructor
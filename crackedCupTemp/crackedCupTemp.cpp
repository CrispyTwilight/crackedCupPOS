// This is a testing file with all classes definitions included in one file.

#include <iostream>
#include <string>
#include <vector>
#include <fstream>

// Forward declarations
struct Product;
class Order;
class Order_TakeOut;
class Order_InStore;

struct Transaction;
class Payment;
class Payment_Cash;
class Payment_Card;

// Function Prototypes
void cardTxDriver();
void cashTxDriver();
bool writeTransactionToFile(Payment& payment);

using namespace std;

// This struct is used to store transaction information.
struct Transaction {
	int orderID;
	int transactionID;
	int paymentTypeCode;
	int paymentStatusCode;
	double transactionAmount;
	std::string date;
	std::string time;
	std::string type;

	// Constructor with default values and member initializer list
	Transaction(int const& ordID = 0, int const& transID = 0, int const& payType = 0, int const& payStatus = 0, double const& transAmount = 0.0, std::string const& d = "", std::string const& t = "", std::string const& ty = "")
		: orderID(ordID), transactionID(transID), paymentTypeCode(payType), paymentStatusCode(payStatus), transactionAmount(transAmount), date(d), time(t), type(ty)
	{}
};

// This class is used to store payment information.
class Payment {
private:
	// Create and instance of the Transaction structure. This has all the necessary attributes for a transaction.
	Transaction transaction;

public:
	// Constructor
	Payment() : transaction() {}

	// Virtual destructor needed for polymorphism.
	virtual ~Payment() = default;

	// Getters
	int getOrderID() const { return transaction.orderID; };
	int getTransactionID() const { return transaction.transactionID; };
	int getPaymentType() const { return transaction.paymentTypeCode; };
	int getPaymentStatus() const { return transaction.paymentStatusCode; };
	double getTransactionAmount() const { return transaction.transactionAmount; }
	std::string getDate() const { return transaction.date; }
	std::string getTime() const { return transaction.time; }
	std::string getType() const { return transaction.type; }

	// Setters
	void setOrderID(int const& oID) { transaction.orderID = oID; }
	void setTransactionID(int const& txID) { transaction.transactionID = txID; }
	void setPaymentType(int const& pType) { transaction.paymentTypeCode = pType; }
	void setPaymentStatus(int const& pStatus) { transaction.paymentStatusCode = pStatus; }
	void setTransactionAmount(double const& txAmount) { transaction.transactionAmount = txAmount; }
	void setDate(std::string const& date) { transaction.date = date; }
	void setTime(std::string const& time) { transaction.time = time; }
	void setType(std::string const& type) { transaction.type = type; }

	// Member functions
	void processPayment() const {
		// This method will process the payment
	};

	void processRefund() const {
		// This method will process the refund
	};
	void printReceipt() const {
		// This method will print the receipt
	};
	void printRefundReceipt() const {
		// This method will print the refund receipt
	};
};

// This class extends the Payment class for cash payments.
class Payment_Cash : public Payment {
private:
	double amountTendered;
	double changeDue;

public:
	// Constructor with default values and member initializer list
	Payment_Cash(double const& amtTend = 0.0, double const& chngeDue = 0.0)
		: amountTendered(amtTend), changeDue(chngeDue) {}

	// Getters
	double getAmountTendered() const { return amountTendered; }
	double getChangeDue() const { return changeDue; }

	// Setters
	void setAmountTendered(double const& amtTend) { amountTendered = amtTend; }
	void setChangeDue(double const& chngeDue) { changeDue = chngeDue; }
};

// This class extends the Payment class for card payments.
class Payment_Card : public Payment {
private:
    std::string cardNumber;
    std::string expiryDate;
    std::string cardHolderName;
    std::string CVV;

public:
    // Constructor with default values and member initializer list
    Payment_Card(std::string const& cardNum = "", std::string const& expDate = "", std::string const& cardHolder = "", std::string const& cvv = "")
        : Payment(), cardNumber(cardNum), expiryDate(expDate), cardHolderName(cardHolder), CVV(cvv) {}

    // Getters
    std::string getCardNumber() const { return cardNumber; }
    std::string getExpiryDate() const { return expiryDate; }
    std::string getCardHolderName() const { return cardHolderName; }
    std::string getCVV() const { return CVV; }

    // Setters
	void setCardNumber(std::string const& cardNum) { cardNumber = cardNum; }
	void setExpiryDate(std::string const& expDate) { expiryDate = expDate; }
	void setCardHolderName(std::string const& cardHolder) { cardHolderName = cardHolder; }
	void setCVV(std::string const& cvv) { CVV = cvv; }
};

// This struct is used to store product information.
struct Product {
	int productID;
	std::string productName;
	std::string productDescription;
	double productPrice;
	int productQuantity;

	// Constructor with default values and member initializer list
};

// This class is used to store order information.
class Order {
private:
	int orderID;
	int orderType;
	int orderStatus;
	int orderQuantity;
	double orderTotal;
	std::vector<Product> orderProducts;

public:
	// Constructor with default values and member initializer list

	// getters

	// setters

	// member functions
};

// This class extends the Order class for takeout orders.
class Order_TakeOut : public Order {
private:
	std::string customerName;
	std::string pickupTime;

public:
	// Constructor with default values and member initializer list

	// getters

	// setters

	// member functions
};

// This class extends the Order class or in-store orders.
class Order_InStore : public Order {
private:
	std::string customerName;
	std::string tableNumber;

public:
	// Constructor with default values and member initializer list

	// getters

	// setters

	// member functions
};

int main() {
	cout << "Welcome to the Cracked Cup POS!\n"
		<< "-------------------------------\n";
	int choice;

	do {
		cout << "Please select an option:\n"
			<< "1. Test Order_InStore\n"
			<< "2. Test Order_TakeOut\n"
			<< "3. Test Transaction_Card\n"
			<< "4. Test Transaction_Cash\n"
			<< "5. Exit\n"
			<< "Choice: ";
		cin >> choice;

		// This switch structure is a driver to test all functions of the superclasses, subclasses, and structures. The superclasses and structures are not tested directly; they are tested via the subclasses.
		switch (choice) {
			case 1: {
				cout << "Testing Order_InStore...\n";
				// Call methods on Order_InStore instance to test them
				break;
			}
			case 2: {
				cout << "Testing Order_TakeOut...\n";
				// Call methods on Order_TakeOut instance to test them
				break;
			}
			case 3: {
				cout << "Testing Transaction_Card...\n";
				// Call methods on Transaction_Card instance to test them
				cardTxDriver();
				break;
			}
			case 4: {
				cout << "Testing Transaction_Cash...\n";
				// Call methods on Transaction_Cash instance to test them
				cashTxDriver();
				break;
			}
			case 5: {
				cout << "Exiting...\n";
				break;
			}
			default: {
				cout << "Invalid choice. Please try again.\n";
				break;
			}
		}
		if (choice != 5) {
			system("pause");  // Pause the program
			system("cls");  // Clear the console
		}
	} while (choice != 5);
	return 0;
}

void cardTxDriver() {
    // Create an instance of Payment_Card with default values
    Payment_Card card;

    // Use setters to change the values
    card.setCardNumber("1234567890123456");
    card.setExpiryDate("1225");
    card.setCardHolderName("John Doe");
    card.setCVV("123");

	// Set values for the base Payment class
    card.setTransactionID(12345);
    card.setOrderID(67890);
    card.setPaymentType(1);
    card.setPaymentStatus(0);
    card.setTransactionAmount(15.00);
    card.setDate("2022-01-01");
    card.setTime("12:00:00");
    card.setType("Card");

    // Use getters to print the details
    cout << "Card Number: " << card.getCardNumber() << "\n";
    cout << "Expiry Date: " << card.getExpiryDate() << "\n";
    cout << "Card Holder Name: " << card.getCardHolderName() << "\n";
    cout << "CVV: " << card.getCVV() << "\n";

	// Print the details of the base Payment class
    cout << "Transaction ID: " << card.getTransactionID() << "\n";
    cout << "Order ID: " << card.getOrderID() << "\n";
    cout << "Payment Type: " << card.getPaymentType() << "\n";
    cout << "Payment Status: " << card.getPaymentStatus() << "\n";
    cout << "Transaction Amount: " << card.getTransactionAmount() << "\n";
    cout << "Date: " << card.getDate() << "\n";
    cout << "Time: " << card.getTime() << "\n";
    cout << "Type: " << card.getType() << "\n";

	bool result = writeTransactionToFile(card);
	if (result)
		cout << "\nTest passed: Transaction details were written to the file successfully.\n";
	else
		cout << "\nTest failed: Transaction details could not be written to the file.\n";
}

void cashTxDriver() {
    // Create an instance of Payment_Cash with default values
    Payment_Cash cash;

    // Use setters to change the values
    cash.setAmountTendered(20.00);
    cash.setChangeDue(5.00);

    // Set values for the base Payment class
    cash.setTransactionID(12345);
    cash.setOrderID(67890);
    cash.setPaymentType(1);
    cash.setPaymentStatus(0);
    cash.setTransactionAmount(15.00);
    cash.setDate("2022-01-01");
    cash.setTime("12:00:00");
    cash.setType("Cash");

    // Use getters to print the details
    cout << "Amount Tendered: " << cash.getAmountTendered() << "\n";
    cout << "Change Due: " << cash.getChangeDue() << "\n";

    // Print the details of the base Payment class
    cout << "Transaction ID: " << cash.getTransactionID() << "\n";
    cout << "Order ID: " << cash.getOrderID() << "\n";
    cout << "Payment Type: " << cash.getPaymentType() << "\n";
    cout << "Payment Status: " << cash.getPaymentStatus() << "\n";
    cout << "Transaction Amount: " << cash.getTransactionAmount() << "\n";
    cout << "Date: " << cash.getDate() << "\n";
    cout << "Time: " << cash.getTime() << "\n";
    cout << "Type: " << cash.getType() << "\n";

	bool result = writeTransactionToFile(cash);
	if (result)
		cout << "\nTest passed: Transaction details were written to the file successfully.\n";
	else
		cout << "\nTest failed: Transaction details could not be written to the file.\n";
}

bool writeTransactionToFile(Payment& payment) {
    // Check if the file exists by trying to open it. If it doesn't exist, create it.
    ifstream checkFile("transactions.csv");
    bool fileExists = checkFile.good();
    checkFile.close();

    ofstream transactionFile;
    transactionFile.open("transactions.csv", std::ios::app); // Open the file in append mode

    if (!transactionFile) {
        return false; // Return false if the file couldn't be opened
    }

    // If the file didn't exist, write the header line
    if (!fileExists) {
        transactionFile << "Transaction ID,Order ID,Payment Type,Payment Status,Transaction Amount,Date,Time,Type,Amount Tendered,Change Due,Card Number,Expiry Date,Card Holder Name,CVV\n";
    }
    // Write the common transaction details to the file
    transactionFile << payment.getTransactionID() << ","
                    << payment.getOrderID() << ","
                    << payment.getPaymentType() << ","
                    << payment.getPaymentStatus() << ","
                    << payment.getTransactionAmount() << ","
                    << payment.getDate() << ","
                    << payment.getTime() << ","
                    << payment.getType();

    // Check if the Payment object is a Payment_Cash object
    auto const* cash = dynamic_cast<Payment_Cash*>(&payment);
    if (cash != nullptr) {
        // Write the cash-specific details to the file
        transactionFile << "," << cash->getAmountTendered() << ","
                        << cash->getChangeDue();
    }

    // Check if the Payment object is a Payment_Card object
    auto const* card = dynamic_cast<Payment_Card*>(&payment);
    if (card != nullptr) {
        // Write the card-specific details to the file with empty values for the cash-specific details
        transactionFile << ",,," << card->getCardNumber() << ","
                        << card->getExpiryDate() << ","
                        << card->getCardHolderName() << ","
                        << card->getCVV();
    }

    transactionFile << "\n"; // End the line
    transactionFile.close(); // Close the file
	return true; // Return true if the function succeeded
}
// Auth: John O'Neal
// Date: 11/13/2023
// Desc: This is a testing file with all classes definitions included in one file.

#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <sstream>
#include <ctime>

// Forward declarations
struct Transaction;
class Payment;
class Payment_Cash;
class Payment_Card;

using namespace std;

// This struct is used to store transaction information.
struct Transaction {
	int orderID;
	int transactionID;
	int paymentTypeCode;
	int paymentStatusCode;
	double subtotal;
	double tax;
	double totalCost;
	string date;
	string time;
	static int nextOrderID; // Static variable to ensure unique orderID
	static int nextTransactionID; // Static variable to ensure unique transactionID

	// Constructor with default values and member initializer list
	Transaction(int transactionID = nextTransactionID, int orderID = nextOrderID, int paymentTypeCode = 0, int paymentStatusCode = 0, double subtotal = 0.0, double tax = 0.0, double totalCost = 0.0, const string& date = "", const string& time = "")
    : orderID(orderID), transactionID(transactionID), paymentTypeCode(paymentTypeCode), paymentStatusCode(paymentStatusCode), subtotal(subtotal), tax(tax), totalCost(totalCost), date(date), time(time) {
        nextTransactionID++;
        nextOrderID++;
    }
};

// This class is used to store payment information.
class Payment {
private:
	// Create and instance of the Transaction structure. This has all the necessary attributes for a transaction.
	Transaction transaction;
	const double TAX_RATE = 0.07;

public:
	// Constructor with default values and member initializer list
	Payment(int transactionID = Transaction::nextTransactionID, int orderID = Transaction::nextOrderID, int paymentTypeCode = 0, int paymentStatusCode = 0, double subtotal = 0.0, double tax = 0.0, double totalCost = 0.0, const string& date = "", const string& time = "")
		: transaction(transactionID, orderID, paymentTypeCode, paymentStatusCode, subtotal, tax, totalCost, date, time) {}

	// Virtual destructor needed for polymorphism.
	virtual ~Payment() = default;

	// Getters
	int getOrderID() const { return transaction.orderID; };
	int getTransactionID() const { return transaction.transactionID; };
	int getPaymentTypeCode() const { return transaction.paymentTypeCode; };
	int getPaymentStatusCode() const { return transaction.paymentStatusCode; };
	double getSubtotal() const { return transaction.subtotal; }
	double getTax() const { return transaction.tax; }
	double getTotalCost() const { return transaction.totalCost; }
	string getDate() const { return transaction.date; }
	string getTime() const { return transaction.time; }

	// Setters
	void setOrderID(int const& oID) { transaction.orderID = oID; }
	void setTransactionID(int const& txID) { transaction.transactionID = txID; }
	void setPaymentTypeCode(int const& pType) { transaction.paymentTypeCode = pType; }
	void setPaymentStatusCode(int const& pStatus) { transaction.paymentStatusCode = pStatus; }
	void setSubtotal(double const& sub) { transaction.subtotal = sub; }
	void setTax() { transaction.tax = transaction.subtotal*TAX_RATE; }
	void setTotalCost() { transaction.totalCost = transaction.subtotal + transaction.tax; }
	void setDate(string const& date) { transaction.date = date; }
	void setTime(string const& time) { transaction.time = time; }

	// Member functions
	void processRefund() {
		cout << "\nRefunding transaction " << getTransactionID() << "...\n";
		setSubtotal(getSubtotal() * -1);
		setTax();
		setTotalCost();
		setPaymentStatusCode(2);  // Set to 2 to indicate refund is successful
		cout << "Refund successful.\n";
	}

	virtual void printReceipt() {
        cout << "Date: " << getDate() << '\n';
        cout << "Time: " << getTime() << '\n';
        cout << "Order ID: " << getOrderID() << '\n';
        cout << "Transaction ID: " << getTransactionID() << '\n';
        cout << "Payment Type Code: " << getPaymentTypeCode() << '\n';
        cout << "Payment Status Code: " << getPaymentStatusCode() << '\n';
        cout << "Subtotal: " << getSubtotal() << '\n';
        cout << "Tax: " << getTax() << '\n';
        cout << "Total Cost: " << getTotalCost() << '\n';
    }

    virtual void writeTransactionToFile() {
        // Open the file in append mode
        ofstream transactionFile("transactions.csv", ios::ate | ios::app);
        if (!transactionFile) {
            cout << "\nError: Could not open transactions.csv for writing.\n";
            return;
        }

		// Check if the file is new or empty
		transactionFile.seekp(0, ios::end);
		if (transactionFile.tellp() == 0) {
			// Write the header row
			transactionFile << "Date,Time,Order ID,Transaction ID,Payment Type Code,Payment Status Code,Subtotal,Tax,Total Cost,Amount Tendered, Change Due,Card Number,Expiry Date,Card Holder Name,CVV\n";
		}

        // Write the common details to the file
        transactionFile << getDate() << ","
                        << getTime() << ","
                        << getOrderID() << ","
                        << getTransactionID() << ","
                        << getPaymentTypeCode() << ","
                        << getPaymentStatusCode() << ","
                        << getSubtotal() << ","
						<< getTax() << ","
						<< getTotalCost() << ",";

        transactionFile.close(); // Close the file

        // Print a success message
        cout << "\nTransaction written to file successfully.\n";
    }

	void readTransactionFromFile(vector<Payment>& transactions) const {
		ifstream transactionFile("transactions.csv");
		if (!transactionFile) {
			cout << "Error: Could not open transactions.csv for reading.\n";
			return;
		}

		string line;
		// Skip the header line by reading it into a dummy variable
		getline(transactionFile, line);

		while (getline(transactionFile, line)) {
			stringstream ss(line);
			string field;
			vector<string> fields;

			while (getline(ss, field, ',')) {
				fields.push_back(field);
			}

			try {
				Payment payment(stoi(fields[0]), stoi(fields[1]), stoi(fields[2]), stoi(fields[3]), stod(fields[4]), stod(fields[5]), stod(fields[6]), fields[7], fields[8]);
				transactions.push_back(payment);
			} catch (exception& e) {
				cout << "Error: Could not parse line in transactions.csv: " << line << "\n";
			}
		}

		if (transactions.empty()) {
			cout << "No transactions found in the file.\n";
		} else {
			cout << "Transactions read from file successfully.\n";
		}
	}

	void searchTransactionByOrderID(int orderID, const vector<Payment>& transactions) const {
		for (const auto& payment : transactions) {
			cout << "Checking order ID: " << payment.getOrderID() << '\n';
			if (payment.getOrderID() == orderID) {
				cout << "Transaction found!\n";
				return;
			}
		}
		// If no match was found, print an error message
		cout << "No transaction found with order ID " << orderID << ".\n";
	}
};

// This class extends the Payment class for cash payments.
class Payment_Cash : public Payment {
private:
	double amountTendered;
	double changeDue;

public:
	// Constructor with default values and member initializer list
	Payment_Cash(double const& amtTend = 0.0, double const& chngeDue = 0.0)
        : Payment(), amountTendered(amtTend), changeDue(chngeDue) {}

	// Getters
	double getAmountTendered() const { return amountTendered; }
	double getChangeDue() const { return changeDue; }

	// Setters
	void setAmountTendered(double const& amtTend) { amountTendered = amtTend; }
	void setChangeDue() {
		changeDue = amountTendered - getTotalCost();  // Calculate changeDue based on amountTendered and totalCost
		if (changeDue < 0) {
			changeDue = 0;  // If the customer didn't tender enough money, there's no change, they still owe the difference
		}
	}

	// Member functions
	void processPayment() {
		if (amountTendered <= 0.0 || amountTendered < getTotalCost()) {
			cout << "Insufficient funds. Payment failed.\n";
			return;
		}
		// Update the payment info specific to cash payments
		setPaymentStatusCode(1);  // Set to 1 to indicate payment is successful
		setPaymentTypeCode(1);
		cout << "Payment successful.\n";
	}

	void printReceipt() override {
        // Call the superclass's printReceipt function
        Payment::printReceipt();

        // Print the cash-specific details
        cout << "Amount Tendered: " << getAmountTendered() << '\n';
		cout << "Change Due: " << getChangeDue() << '\n';
    }

    void writeTransactionToFile() override {
        // Call the superclass's writeTransactionToFile function
        Payment::writeTransactionToFile();

		// Open the file in append mode
		ofstream transactionFile("transactions.csv", ios::ate | ios::app);
		if (!transactionFile) {
			cout << "Error: Could not open transactions.csv for writing.\n";
			return;
		}

        // Write the cash-specific details to the file
        transactionFile << getAmountTendered() << ","
						<< getChangeDue() << "\n";

		transactionFile.close(); // Close the file
    }
};

// This class extends the Payment class for card payments.
class Payment_Card : public Payment {
private:
    string cardNumber;
    string expiryDate;
    string cardHolderName;
    string CVV;

public:
    // Constructor with default values and member initializer list
     Payment_Card(string const& cardNum = "", string const& expDate = "", string const& cardHolder = "", string const& cvv = "")
        : Payment(), cardNumber(cardNum), expiryDate(expDate), cardHolderName(cardHolder), CVV(cvv) {}

    // Getters
    string getCardNumber() const { return cardNumber; }
    string getExpiryDate() const { return expiryDate; }
    string getCardHolderName() const { return cardHolderName; }
    string getCVV() const { return CVV; }

    // Setters
	void setCardNumber(string const& cardNum) { cardNumber = cardNum; }
	void setExpiryDate(string const& expDate) { expiryDate = expDate; }
	void setCardHolderName(string const& cardHolder) { cardHolderName = cardHolder; }
	void setCVV(string const& cvv) { CVV = cvv; }

	// Member functions
	void processPayment() {
		if (cardNumber == "" || expiryDate == "" || cardHolderName == "" || CVV == "") {
			cout << "Invalid card information. Payment failed.\n";
			return;
		}
		// Update the payment info specific to cash payments
		setPaymentStatusCode(1);  // Set to 1 to indicate payment is successful
		setPaymentTypeCode(2);
		cout << "Payment successful.\n";
	}

	void printReceipt() override {
        // Call the superclass's printReceipt function
        Payment::printReceipt();

        // Print the card-specific details
        cout << "Card Number: " << getCardNumber() << '\n';
        cout << "Expiry Date: " << getExpiryDate() << '\n';
        cout << "Card Holder Name: " << getCardHolderName() << '\n';
        cout << "CVV: " << getCVV() << '\n';
    }

    void writeTransactionToFile() override {
        // Call the superclass's writeTransactionToFile function
        Payment::writeTransactionToFile();

		// Open the file in append mode
		ofstream transactionFile("transactions.csv", ios::ate | ios::app);
		if (!transactionFile) {
			cout << "Error: Could not open transactions.csv for writing.\n";
			return;
		}

        // Write the cash-specific details to the file
        transactionFile << "," << ","
						<< getCardNumber() << ","
						<< getExpiryDate() << ","
						<< getCardHolderName() << ","
						<< getCVV() << "\n";

		transactionFile.close(); // Close the file
    }
};

// Function Prototypes
void cardPurchaseDriver();
void cardReturnDriver();
void cashPurchaseDriver();
void cashReturnDriver();

// Define and initialize the static variables in the global scope
int Transaction::nextOrderID = 0;
int Transaction::nextTransactionID = 0;

int main() {
	const int QUIT_OPTION = 7;
	cout << "Welcome to the Cracked Cup POS!\n"
		<< "-------------------------------\n";
	int choice;
	vector<Payment> transactions;
	Payment payment;

	do {
		cout << "Please select an option:\n"
			<< "1. Test Order_InStore\n"
			<< "2. Test Order_TakeOut\n"
			<< "3. Test Transaction_Card\n"
			<< "4. Test Transaction_Cash\n"
			<< "5. Read transactions from file\n"
			<< "6. Search transactions by order ID\n"
			<< QUIT_OPTION << ". Exit\n"
			<< "Choice: ";
		cin >> choice;
		cout << '\n';

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
				cardPurchaseDriver();
				cardReturnDriver();
				break;
			}
			case 4: {
				cout << "Testing Transaction_Cash...\n";
				// Call methods on Transaction_Cash instance to test them
				cashPurchaseDriver();
				cashReturnDriver();
				break;
			}
			case 5: {
				payment.readTransactionFromFile(transactions);
				break;
			}
			case 6: {
				int orderID;
				cout << "Enter an order ID to search for: ";
				cin >> orderID;
				payment.searchTransactionByOrderID(orderID, transactions);
				break;
			}
			case QUIT_OPTION: {
				cout << "Exiting...\n";
				break;
			}
			default: {
				cout << "Invalid choice. Please try again.\n";
				break;
			}
		}
		if (choice != QUIT_OPTION) {
			system("pause");  // Pause the program
			system("cls");  // Clear the console
		}
	} while (choice != QUIT_OPTION);
	return 0;
}

void cardPurchaseDriver() {
    // Create an instance of Payment_Card with default values
    Payment_Card card;
	// Time and date variables
	tm ltm;
	time_t now = time(0);
	localtime_s(&ltm, &now);

    // Set values for the base Transaction class
	card.setDate(to_string(1900 + ltm.tm_year) + "-" + to_string(1 + ltm.tm_mon) + "-" + to_string(ltm.tm_mday));
	card.setTime(to_string(1 + ltm.tm_hour) + ":" + to_string(1 + ltm.tm_min) + ":" + to_string(1 + ltm.tm_sec));
    card.setSubtotal(15.00);
    card.setTax();
    card.setTotalCost();
	card.setCardNumber("1234567890123456");
    card.setExpiryDate("1225");
    card.setCardHolderName("John Doe");
    card.setCVV("123");

    // Call the processPayment method
    card.processPayment();

 	// Call the printReceipt method
    card.printReceipt();

	// Call the writeTransactionToFile method
	card.writeTransactionToFile();
}

void cardReturnDriver() {
	// Create an instance of Payment_Card with default values
	Payment_Card card;
	// Time and date variables
	tm ltm;
	time_t now = time(0);
	localtime_s(&ltm, &now);

	// Set values for the base Transaction class
	card.setDate(to_string(1900 + ltm.tm_year) + "-" + to_string(1 + ltm.tm_mon) + "-" + to_string(ltm.tm_mday));
	card.setTime(to_string(1 + ltm.tm_hour) + ":" + to_string(1 + ltm.tm_min) + ":" + to_string(1 + ltm.tm_sec));
	card.setSubtotal(15.00);
	card.setTax();
	card.setTotalCost();
	card.setCardNumber("1234567890123456");
	card.setExpiryDate("1225");
	card.setCardHolderName("John Doe");
	card.setCVV("123");

	// Call the processRefund method
	card.processRefund();

	// Call the printReceipt method
	card.printReceipt();

	// Call the writeTransactionToFile method
	card.writeTransactionToFile();
}

void cashPurchaseDriver() {
	// Create an instance of Payment_Cash with default values
	Payment_Cash cash;
	// Time and date variables
	tm ltm;
	time_t now = time(0);
	localtime_s(&ltm, &now);

	// Set values for the base Payment class
	cash.setDate(to_string(1900 + ltm.tm_year) + "-" + to_string(1 + ltm.tm_mon) + "-" + to_string(ltm.tm_mday));
	cash.setTime(to_string(1 + ltm.tm_hour) + ":" + to_string(1 + ltm.tm_min) + ":" + to_string(1 + ltm.tm_sec));
	cash.setSubtotal(15.00);
	cash.setTax();
	cash.setTotalCost();
	cash.setAmountTendered(20.00);
	cash.setChangeDue();

	// Call the processPayment method
	cash.processPayment();

	// Call the printReceipt method
	cash.printReceipt();

	// Call the writeTransactionToFile method
	cash.writeTransactionToFile();
}

void cashReturnDriver() {
	// Create an instance of Payment_Cash with default values
	Payment_Cash cash;
	// Time and date variables
	tm ltm;
	time_t now = time(0);
	localtime_s(&ltm, &now);

	// Set values for the base Payment class
	cash.setDate(to_string(1900 + ltm.tm_year) + "-" + to_string(1 + ltm.tm_mon) + "-" + to_string(ltm.tm_mday));
	cash.setTime(to_string(1 + ltm.tm_hour) + ":" + to_string(1 + ltm.tm_min) + ":" + to_string(1 + ltm.tm_sec));
	cash.setSubtotal(15.00);
	cash.setTax();
	cash.setTotalCost();
	cash.setAmountTendered(20.00);
	cash.setChangeDue();

	// Call the processRefund method
	cash.processRefund();

	// Call the printReceipt method
	cash.printReceipt();

	// Call the writeTransactionToFile method
	cash.writeTransactionToFile();
}
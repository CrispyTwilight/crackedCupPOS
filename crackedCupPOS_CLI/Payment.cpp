// Auth: John O'Neal
// Date: 11/08/2023
// Desc: Payment SuperClass

#include "Transaction.cpp"

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
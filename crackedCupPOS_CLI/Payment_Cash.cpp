// Auth: John O'Neal
// Date: 11/08/2023
// Desc: Payment_Cash Subclass

#include "Payment.cpp"

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
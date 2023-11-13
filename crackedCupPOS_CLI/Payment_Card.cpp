// Auth: John O'Neal
// Date: 11/08/2023
// Desc: Payment_Card SubClass

#include "Payment.cpp"

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
// Auth: John O'Neal
// Date: 11/08/2023
// Desc: Transaction Structure

#include <string>

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
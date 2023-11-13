// Auth: John O'Neal
// Date: 11/08/2023
// Desc: Product Structure

#include <string>

// This struct is used to store product information.
struct Product {
	int productID;
	std::string productName;
	std::string productDescription;
	double productPrice;
	int productQuantity;

	// Constructor with default values and member initializer list
};
// Auth: John O'Neal
// Date: 11/08/2023
// Desc: Order SuperClass.

#include <vector>
#include "Product.cpp"

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
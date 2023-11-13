// Auth: John O'Neal
// Date: 11/08/2023
// Desc: CLI app for the Cracked Cup POS
#include <iostream>

using namespace std;

int main() {
	cout << "Welcome to the Cracked Cup POS!\n"
		 << "-------------------------------\n";
	int choice;

	do {
		cout << "Please select an option:\n"
		     << "1. Testing Order_InStore\n"
		     << "2. Testing Order_TakeOut\n"
		     << "3. Testing Transaction_Card\n"
		     << "4. Testing Transaction_Cash\n"
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
				break;
			}
			case 4: {
				cout << "Testing Transaction_Cash...\n";
				// Call methods on Transaction_Cash instance to test them
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
#include <iostream>
using namespace std;

// function for remainder of two numbers

 int remainder (int n1, int n2){
 	int remainder = n1 % n2;
 	
 	return remainder;
 }

int main (){
	
	int n1, n2;
	
	// getting their number 1, number 2 from the user
	cout << "Enter number 1: ";
	cin >> n1;
	cout << "Enter number 2: ";
	cin >> n2;
	
	// diplaying the result
	cout << "The remainder of two number is: " << remainder(n1, n2);

	return 0;
}
#include <iostream>;
using namespace std;

// function for incrementing by one 

int incre_one (int num){
	
	// incrementing and adding one and returning it to a function
	return num + 1;
}

int main (){
	
	int num;
	
	// Getting a number to a user
	cout << "Enter a number: ";
	cin >> num;
	
	// displaying the incremented value
	cout << "Have been incremented by one :) " << incre_one(num);
	
}
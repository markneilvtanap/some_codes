#include <iostream>;
using namespace std;

// function for adding and returning the result/ total
int add (int num1, int num2){
	
	// adding the paramameters
	int result = num1 + num2;
	
	// returning the result
	return result;
}

int main (){
	
	// showing the result and passing the arguments to add function
	cout << "the total is: " << add(-3, -6);
}
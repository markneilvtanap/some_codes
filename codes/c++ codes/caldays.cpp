#include <iostream>
using namespace std;

// function for converting age to days
int cal_age (int age){
	

		int days = age * 365;
		
		return days;
	
}

int main (){
	
	int age;
	
	// getting their age in user
	cout << "Enter your age: ";
	cin >> age;
	
	// checking if user put a positive or negative number
	if (age <= 0){
		cout << "Wrong Input please Enter a positve number: ";
		
	}
	else{
	
	// diplaying the result
	cout << "The days is: " << cal_age(age);
}

	return 0;
}
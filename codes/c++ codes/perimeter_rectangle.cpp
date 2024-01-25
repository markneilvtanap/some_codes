#include <iostream>
using namespace std;

// function for perimeter of rectangle

 int peri_rec (int l, int w){
 	int perimeter = 2*(l + w);
 	
 	return perimeter;
 }

int main (){
	
	int length, width;
	
	// getting their number 1, number 2 from the user
	cout << "Enter number 1: ";
	cin >> length;
	cout << "Enter number 2: ";
	cin >> width;
	
	// diplaying the result
	cout << "The perimeter of two number is: " << peri_rec(length, width);

	return 0;
}
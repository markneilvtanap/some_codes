#include <iostream>
using namespace std;

// function for getting max edge of triangle 

 int max_triangle (int s1, int s2){
 	int s3 = (s1 + s2) - 1;
 	
 	return s3;
 }

int main (){
	
	int side1, side2;
	
	// getting their side 1, side 2 from the user
	cout << "Enter side 1: ";
	cin >> side1;
	cout << "Enter side 2: ";
	cin >> side2;
	
	// diplaying the result
	cout << "The max triangle is: " << max_triangle(side1, side2);

	return 0;
}
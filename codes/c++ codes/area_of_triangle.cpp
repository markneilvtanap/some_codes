#include <iostream>
using namespace std;

// function for calculating the area of triangle

int triArea(int base, int height){
	
	// formula for area of triangle
	int area = (base * height) / 2;
	
	return area;
}

int main (){
	
	int base, height;
	
	cout << "Enter a base: ";
	cin >> base;
	
	cout << "Enter a height: ";
	cin >> height;
	
	cout << "The area of triangle is: " << triArea(base, height);
	
	return 0;
}
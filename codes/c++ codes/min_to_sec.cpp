#include <iostream>;
using namespace std;

// function to convert a minute to seconds
int convert (int minute){
	
	// my formula is minute x 60 to get it seconds
	int sec = minute * 60;
	
	// returning sec 
	return sec;
	
	
}


int main (){
	
	int minute;
	
	// getting a minute to user 
	cout << "Enter a minute: ";
	cin >> minute;
	
	// display the convertion of minute to seconds
	cout << "The convert of " << minute << " minutes to sec is " << convert(minute); 
}
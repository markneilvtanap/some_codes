#include <iostream>
using namespace std;

// function for getting the electrical power

 int circuit_pow (int voltage, int elec_cur){
 	int elec_power = voltage * elec_cur;
 	
 	return elec_power;
 }

int main (){
	
	int voltage, i;
	
	// getting their voltage & electrical current in user
	cout << "Enter voltage: ";
	cin >> voltage;
	cout << "Enter electric current: ";
	cin >> i;
	
	// diplaying the result
	cout << "The electrical power: " << circuit_pow(voltage, i);

	return 0;
}
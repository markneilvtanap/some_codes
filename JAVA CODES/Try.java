

import java.util.Scanner;
import java.util.Stack;

public class Try{

public static void main (String []args){
	Scanner in = new Scanner (System.in);
	Stack <Character> stack = new Stack <Character>();
	
	String infix;
	byte icp = 0;
	byte isp = 0;
	
	// get infix value to convert in postfix
	System.out.print("Enter a infix to convert: ");
	infix = in.nextLine();
	// Accessing individually for converting it to postfix 
	char [] toInfix = new char [1000];
	char [] postFix = new char [1000];
	toInfix = infix.toCharArray();
// a+b+c
for (int x = 0; x < 100; x++) {
	if (Character.isAlphabetic(toInfix[x]) || Character.isDigit(toInfix[x])) {
		postFix[x] = toInfix[x];
	}
	else {
		if (toInfix[x] == '+' || toInfix[x] == '-') {
			if (stack.isEmpty()) {
				stack.push(toInfix[x]);
			
			}
			else
			{
				if (stack.peek() == '+' || stack.peek() == '-') {
					icp = 1;
					isp = 2;
					
					if (icp < isp){
						postFix[x] = toInfix[x];
					}
				}
				
				else if (stack.peek() == '*' || stack.peek() == '/') {
					icp = 3;
					isp = 4;
					
					if (icp < isp){
						postFix[x] = toInfix[x];
					}
				}
				
				else if (stack.peek() == '^') {
					icp = 6;
					isp = 5;
					
					if (icp > isp){
						stack.push(toInfix[x]);
					}
			}
				
				else if (stack.peek() == '(') {
					stack.push(toInfix[x]);
				}
				else if (stack.peek() == ')') {
					do {
					postFix[x] = toInfix[x - 1];
					stack.pop();
					}while(stack.peek() == '(');
				}
			
			
			
			
			
		}
	}
}

	
}
}

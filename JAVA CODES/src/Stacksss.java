import java.util.Scanner;
import java.util.Stack;

	//MARK NEIL V. TANAP
	//2B
	//TUESDAY, 9:00 - 11:00 AM
public class Stacksss {

		public static void main(String[] args) {
	Scanner in = new Scanner (System.in);
			Stack <Character> stack = new Stack <Character>();
			
			String input, postFix = "";
			byte isp = 0, icp = 0;
			
			
			System.out.print("Enter a infix: ");
			input = in.nextLine();
			
			char[] toPostFix = new char[input.length()];
			toPostFix = input.toCharArray();
			
			
			for (int x = 0; x < input.length(); x++) {
				if (Character.isAlphabetic(toPostFix[x]) || Character.isDigit(toPostFix[x])){
					postFix = postFix + toPostFix[x];
				}
				else if (toPostFix[x] == '-' ||  toPostFix[x] == '+' || toPostFix[x] == '*' || toPostFix[x] == '/' || toPostFix[x] == '^' || toPostFix[x] == '(' || toPostFix[x] == ')' ) {
					if (toPostFix[x] == '+' ||  toPostFix[x] == '-' )
					{
						if (stack.isEmpty()) {
							stack.push(toPostFix[x]);
							icp = 1; isp = 2;
							
						}
						else if (!stack.isEmpty()) {
							icp = 1;
							if (icp < isp) {
								postFix= postFix + stack.peek();
							}
							else if (icp > isp) {
								stack.push(toPostFix[x]);
								isp = 1;
							
							}
						}
					}else if(toPostFix[x] == '*' || toPostFix[x] == '/' ) {
						if (stack.isEmpty()) {
							stack.push(toPostFix[x]);
							icp = 3; isp = 4;
							
						}
						else if (!stack.isEmpty()) {
							icp = 3;
							if (icp < isp) {
								postFix= postFix + stack.peek();
							}
							else if (icp > isp) {
								stack.push(toPostFix[x]);
								isp = 3;
							}
						}
					}else if (toPostFix[x] == '^' ) {
						if (stack.isEmpty()) {
							stack.push(toPostFix[x]);
							icp = 6; isp = 5;
							
						}
						else if (!(stack.isEmpty())) {
							icp = 6;
							if (icp < isp) {
								postFix= postFix + stack.peek();
							}
							else if (icp > isp) {
								stack.push(toPostFix[x]);
								isp = 6;
							}
						}
					}else if (toPostFix[x] == '(') {
						stack.push(toPostFix[x]);
						isp = 7;
						
					}else if (toPostFix[x] == ')') {
					while 
					
				}
			}
		
		for (int i=-1; i < stack.size(); i++) {
			postFix = postFix + stack.peek();
			stack.pop();
		
		}
			
			
			for (char show: stack)
			{
				System.out.println(show);
			}
			
		System.out.print("The Postfix form is: " + postFix);
}
}
			
			
			
			
			
			
			
		
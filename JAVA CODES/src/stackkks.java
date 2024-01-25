import java.util.*;
	//MARK NEIL V. TANAP
	//2B
	//TUESDAY, 9:00 - 11:00 AM
public class stackkks {
	
	public static void main (String [] args) {
		Scanner in = new Scanner (System.in);
		Stack <Character> stack = new Stack <Character>();
		
		String input, postFix = "";
		byte isp = 1, icp = 0;
		
		
		System.out.print("Enter a infix (NO SPACE): ");
		input = in.nextLine();
		
		char[] toPostFix = new char[input.length()];
		toPostFix = input.toCharArray();
		
		for (int x = 0; x < input.length(); x++) {
			if (Character.isAlphabetic(toPostFix[x]) || Character.isDigit(toPostFix[x])){
				postFix = postFix + toPostFix[x];
			}else {
				if (toPostFix[x] == '+' ||  toPostFix[x] == '-' ) {
					if (icp < isp) {
						postFix= postFix + stack.peek();
						stack.pop();
						stack.push(toPostFix[x]);
					}
				}
			}
			
			
			
		
			
		System.out.print("The Postfix form is: " + postFix);
		
		

}
}

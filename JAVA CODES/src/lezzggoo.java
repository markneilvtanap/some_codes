import java.util.Scanner;
	
public class lezzggoo {
	
	public static void main(String []args) {
	
		Scanner in = new Scanner(System.in);
		
		int num = 1, sum = 0, highest = 0;
		
		// loop that get user a number until the value is equal to zero then terminate the program
		while (num != 0) {
		//Get a number from a user
			System.out.print("Enter a number: ");
			num = in.nextInt();
		
		// get the sum 
			sum += num;
			
		// check if num is greater then store on highest variable 
			if (num > highest) {
				
				highest = num;
				
			}
		}
		
		in.close();
		
		// Display the desired output
		System.out.println("The highest number is: " + highest);
		System.out.println("The sum is: " + sum);
	}

}

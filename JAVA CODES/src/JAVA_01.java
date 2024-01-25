import java.text.NumberFormat;
import java.util.Arrays;
import java.util.Scanner;
public class JAVA_01 {

	public static void main(String[] args) {
	
	Scanner in = new Scanner(System.in);
	
	int principal;
	
	System.out.println("Principal: ");
	principal = in.nextInt();
	
	System.out.println("Annual INterest Rate: ");
	double annualRate = in.nextDouble();
	
	System.out.println("Period (Years): ");
	int years = in.nextInt();
	
	 // r is the monthly rate = annual rate / 100 / 12
	double r = annualRate /100 / 12;
	// n is the number of payments years * 12
	int n = years * 12;
	
	double mortage = principal * 
			(r * Math.pow(1 + r, n))/ ((Math.pow(1 + r, n)) - 1);
					
	
	String numberFormatted = NumberFormat.getCurrencyInstance().format(mortage);
	System.out.println(numberFormatted);
}
}
import java.util.Scanner;
public class Starting_endingPoint {
	
	public static void main (String []args) {
		Scanner in = new Scanner(System.in);
		
		int startingPoint, endingPoint;
		
		System.out.println("Enter a Starting Point: ");
		startingPoint = in.nextInt();
		
		System.out.println("Enter a Ending Point: ");
		endingPoint = in.nextInt();
		
		if (startingPoint < endingPoint) {
			for (int i = startingPoint; i <= endingPoint; i++) {
				System.out.print(i + ",");
			}
		}
		else if (startingPoint > endingPoint) {
			for (int i = startingPoint; i >= endingPoint; i--) {
				System.out.print(i + ",");
			}
		}
		else {
			do {
				System.out.println("Enter a Starting Point: ");
				startingPoint = in.nextInt();
				
				System.out.println("Enter a Ending Point: ");
				endingPoint = in.nextInt();

			}while(startingPoint == endingPoint);
			
			if (startingPoint < endingPoint) {
				for (int i = startingPoint; i <= endingPoint; i++) {
					System.out.print(i + ",");
				}
			}
			
			else if (startingPoint > endingPoint) {
				for (int i = startingPoint; i >= endingPoint; i--) {
					System.out.print(i + ",");
				}
			}
		}
		
		
		}
		
	}



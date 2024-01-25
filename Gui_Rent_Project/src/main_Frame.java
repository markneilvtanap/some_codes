import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class main_Frame implements ActionListener{
	JButton rent_Button = new JButton();
	JButton pay_Button = new JButton();
	JButton leave_Button = new JButton();
	
	static String [] haha = new String [6];
	JFrame main_Frame = new JFrame();
	

	
	main_Frame(){
		ImageIcon for_label_image = new ImageIcon (this.getClass().getResource("Single-Family-Houses-For-Rent-By-Owner.jpg"));
		
		main_Frame = new JFrame();
		
		JLabel for_Background = new JLabel(for_label_image);
		

		
		rent_Button  = new JButton();
		
		rent_Button.setText("RENT:)");
		rent_Button.setBounds(200,100, 250, 90);
		rent_Button.addActionListener(this);
		
		
		
		pay_Button = new JButton();
		leave_Button = new JButton();
		
		
		for_Background.setSize(750,650);
		
		main_Frame.setTitle("GUI RENTING SYSTEM");
		main_Frame.setSize(750,650);
		main_Frame.setLayout(null);
		main_Frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		main_Frame.setVisible(true);
		main_Frame.add(for_Background);
		main_Frame.setResizable(false);
		main_Frame.add(rent_Button);
		main_Frame.add(pay_Button);
		main_Frame.add(leave_Button);
		
		
		
		for (int i = 0; i < 6;i++) {
			System.out.println(haha[i]);
		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == rent_Button) {
			main_Frame.hide();
		     rent rentFrame = new rent();
		}
		
	}

}

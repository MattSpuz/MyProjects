import java.util.ArrayList;

import javax.swing.JFrame;

import model.Movie;
import view.MainMenuJPanel;

/**  
* Matthew Spuzello - mespuzello  
* CIS171 22149
* Apr 30, 2022  
*/
public class MovieCollectionViewer {
	public static void main(String[] args) {
		JFrame frame = new JFrame();
		MainMenuJPanel panel = new MainMenuJPanel();
		frame.add(panel);
		
		//set size
		frame.setSize(515, 300);
		//set closing operation
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		//set visability
		frame.setVisible(true);
	}

}

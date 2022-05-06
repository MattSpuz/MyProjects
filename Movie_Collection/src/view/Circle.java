package view;



import java.awt.Color;
import java.awt.Graphics;

import javax.swing.JComponent;

import controller.MovieFileHelper;

/**  
* Matthew Spuzello - mespuzello  
* CIS171 22149
* Apr 19, 2022  
*/
public class Circle extends JComponent{

	
	MovieFileHelper fileHelper = new MovieFileHelper();
	Color light = Color.red;
	
	public void paintComponent(Graphics g) {
		
		//checks if there is a file present and if so it makes the circle green
		if(fileHelper.doesAFileExist() == true) {
			light = Color.green;
		}
		g.setColor(light);
		g.fillOval(50, 50, 50, 50);
	}
	
	
	public void changeColor(String color) {
		if(color.equals("green")) {
			light = Color.green;
		} else {
			light = Color.red;
		}
		repaint();
	}
}

package view;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;

import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import model.Movie;
import controller.FileHelper;
import controller.MovieFileHelper;
import view.MainMenuJPanel.ButtonListener;

/**  
* Matthew Spuzello - mespuzello  
* CIS171 22149
* Apr 30, 2022  
*/
public class MainMenuJPanel extends JPanel{
	Circle isEmptyIndicator = new Circle();
	JButton btnAddMovie = new JButton("Add Movie");
	JButton btnClear = new JButton("Clear Movies");
	JTextArea list;
	JScrollPane movieList;
	MovieFileHelper fileHelper = new MovieFileHelper();
	
	//create panel
	public MainMenuJPanel() {
		//JLabel title = new JLabel("MOVIE COLLECTIONS");
		
		JLabel instructions = new JLabel("MOVIE COLLECTIONS" + "\n" + "(SELECT AN OPTION TO CONTINUE) ");
		JLabel circleInstructions = new JLabel("Circle will appear red if collection is empty");
		JLabel circleInstructions2 = new JLabel("on starting the program otherwise its green");
		
		ButtonListener bl = new ButtonListener();
		btnAddMovie.addActionListener(bl);
		btnClear.addActionListener(bl);
		
		JPanel button = new JPanel();
		setLayout(new BorderLayout());
		
		//add the items to the MovieList
		@SuppressWarnings("unchecked")
		ArrayList<Movie> allMovies = (ArrayList<Movie>) fileHelper.readFile();
		String allCoursesFormatted = formatAllMovie(allMovies);
		
		JTextArea commentTextArea = new JTextArea(allCoursesFormatted,5,20);

		movieList = new JScrollPane(commentTextArea);
		//print the movielist on the JPlane
		add(movieList, BorderLayout.EAST);
		
		//add title and instrucitons to panel
		add(instructions, BorderLayout.NORTH);
		
		button.setLayout(new BoxLayout(button, BoxLayout.PAGE_AXIS));
		button.add(btnAddMovie);
		button.add(btnClear);
		button.add(circleInstructions);
		button.add(circleInstructions2);
		button.add(isEmptyIndicator = new Circle());
		//add the buttons to the panel
		add(button, BorderLayout.WEST);
	}
	
	class ButtonListener implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			JPanel newPanel = new JPanel();
			if (e.getSource() == btnAddMovie) {
				isEmptyIndicator.changeColor("green");
				newPanel = new AddMovieJPanel();
			} else if (e.getSource() == btnClear) {
				if(fileHelper.doesAFileExist() == true) {
					fileHelper.deleteFile();
					isEmptyIndicator.changeColor("red");
				}
				newPanel = new MainMenuJPanel();
			} 
			sendToNewPanel(newPanel);

		}

		private void sendToNewPanel(JPanel newPanel) {
			// TODO Auto-generated method stub
			removeAll();
			setVisible(false);
			add(newPanel);
			validate();
			setVisible(true);

		}
		
	}
	
	//format the movies
	public String formatAllMovie(ArrayList<Movie> c){
		StringBuilder sb = new StringBuilder();
		if(fileHelper.doesAFileExist()){
		for(Movie a: c){
			sb.append(a.getName() + " (" + a.getGenre() + ")" + "\n");
		}
		} else {
			sb.append("THIS LIST IS CURRENTLY EMPTY.");
		}
		
		return sb.toString();
	}
	
	
}

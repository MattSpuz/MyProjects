package view;

import javax.swing.JPanel;
import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import controller.MovieFileHelper;
import model.Movie;

/**  
* Matthew Spuzello - mespuzello  
* CIS171 22149
* Apr 30, 2022  
*/
public class AddMovieJPanel extends JPanel{
	private JTextField txtMovieName;
	private JTextField txtMovieGenre;
	JButton btnFinnish = new JButton("Finnish");
	JButton btnClear = new JButton("Clear");
	JButton btnSubmit = new JButton("Submit");
	
	MovieFileHelper fileHelper = new MovieFileHelper();
	ArrayList<Movie> allMovies;
	
	//create the panel
	public AddMovieJPanel() {
		allMovies = (ArrayList<Movie>)fileHelper.readFile();
		
		
		JPanel form = new JPanel();

		JLabel lblMovieName = new JLabel("Movie Name:");
		form.add(lblMovieName);
		
		txtMovieName = new JTextField();
		form.add(txtMovieName, "6, 6, fill");
		txtMovieName.setColumns(10);
		
		JLabel lblMovieGenre = new JLabel("Movie Genre:");
		form.add(lblMovieGenre);
		
		txtMovieGenre = new JTextField();
		form.add(txtMovieGenre, "6, 6, fill");
		txtMovieGenre.setColumns(10);
		
		
		buttonListener bl = new buttonListener();
		btnSubmit.addActionListener(bl);
		btnClear.addActionListener(bl);
		btnFinnish.addActionListener(bl);
		add(form, BorderLayout.CENTER);
		
		add(btnSubmit, "6, 12");
		add(btnClear, "6, 14");
		
		add(btnFinnish, "6, 16");
		
	}
	
	class buttonListener implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
			if (e.getSource() == btnSubmit) {
				Movie MovieToAdd = new Movie(txtMovieName.getText(), txtMovieGenre.getText());

				allMovies.add(MovieToAdd);
				
				//here is where you're going to tell the fileHelper to write to the file
				//uncomment this line below for it to work
				
				fileHelper.writeFile(allMovies);

				clearAllFields();

			} else if (e.getSource() == btnClear) {
				clearAllFields();

			} else if (e.getSource() == btnFinnish) {

				removeAll();
				MainMenuJPanel newPanel = new MainMenuJPanel();
				add(newPanel);
				validate();
				setVisible(true);
			}

		}

		private void clearAllFields() {
			// TODO Auto-generated method stub
			txtMovieName.setText("");
			txtMovieGenre.setText("");
		}

	}
}

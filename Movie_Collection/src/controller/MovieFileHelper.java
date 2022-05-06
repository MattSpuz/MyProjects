package controller;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Scanner;

import model.Course;
import model.Movie;

/**  
* Matthew Spuzello - mespuzello  
* CIS171 22149
* Apr 30, 2022  
*/
public class MovieFileHelper implements FileHelper{
	String nameOfFile = "movie.txt";
	File listOfObjects = new File(nameOfFile);
	
	@Override
	public boolean doesAFileExist() {
		// TODO Auto-generated method stub
		if(listOfObjects.exists()) {
			return true;
		}
		else
			return false;
	}

	@Override
	public boolean writeFile(ArrayList<?> list) {
		// TODO Auto-generated method stub
		ArrayList<Movie> instructorsToWrite = (ArrayList<Movie>)(list);
		
		try {
			PrintWriter listOfObjects = new PrintWriter(nameOfFile);
			for(Movie c: instructorsToWrite){
				StringBuilder sb = new StringBuilder();
				sb.append(c.getName() + "|" +c.getGenre());
				listOfObjects.println(sb.toString());
			}
			
			listOfObjects.close();
		} catch (FileNotFoundException e) {
			System.out.println("No file called " + nameOfFile + " found when writing classrooms.");
			return false;
		}
		
		return true;
	}

	@Override
	public ArrayList<?> readFile() {
		
		ArrayList<Movie> allMovies = new ArrayList<Movie>();
		Scanner fileIn;
		try {
			fileIn = new Scanner(listOfObjects);
			while (fileIn.hasNextLine()) {
				String value = fileIn.nextLine();
				String movie;
				String genre;
				
				//find find the middle point
				int split = 0;
				split = value.indexOf("|");
				
				movie = value.substring(0, split);
				
				genre = value.substring(split + 1, value.length());
				
				Movie currentMovie = new Movie(movie, genre);
				allMovies.add(currentMovie);
			}
			fileIn.close();
		}catch (FileNotFoundException e) {
			System.out.println("No file called " + nameOfFile + " found when reading Instructors.");
		}
		return allMovies;

	}
	
	public void deleteFile() {
		listOfObjects.delete();
		
	}
}

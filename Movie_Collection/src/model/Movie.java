package model;

/**  
* Matthew Spuzello - mespuzello  
* CIS171 22149
* Apr 30, 2022  
*/
public class Movie {
	private String name;
	
	public Movie() {
		setName("");
		setGenre("");
	}
	
	public Movie(String name, String genre) {
		setName(name);
		setGenre(genre);	
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getGenre() {
		return genre;
	}
	public void setGenre(String genre) {
		this.genre = genre;
	}
	private String genre;
	
	
}

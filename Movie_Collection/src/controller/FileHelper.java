package controller;

import java.util.ArrayList;

/**  
* Matthew Spuzello - mespuzello  
* CIS171 22149
* Apr 30, 2022  
*/
public interface FileHelper {
	public boolean doesAFileExist( );
	public boolean writeFile(ArrayList<?> list);
	public ArrayList<?> readFile( );
}

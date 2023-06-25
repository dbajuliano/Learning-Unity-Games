using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour
{
	
	public Text guessText;
	int max = 1000;
	int min = 1;
	int guess;
	int maxGuessesAllowed = 5;
	
	void Start ()
	{
		StartGame ();
	}
	
	void StartGame ()
	{
		max = max + 1;
		NextGuess ();
	}
	
	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}
	
	public void GuessCorrect ()
	{
		StartGame ();
	}
	
	void NextGuess ()
	{
		//guess = (max + min) / 2;
		guess = Random.Range (min, max);
		print ("Next guess is " + guess);
		guessText.text = guess.ToString ();
		
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel ("Win");
		}
	}
}
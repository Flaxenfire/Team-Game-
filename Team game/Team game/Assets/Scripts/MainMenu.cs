using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class MainMenu: MonoBehaviour {  
	public void PlayGame() {  
		SceneManager.LoadScene("Player1");  
	} 
	public void doExitGame() {
		Application.Quit();
		Debug.Log("Game is exiting");
		UnityEditor.EditorApplication.isPlaying = false;
	}
	public void character1Select() {  
		SceneManager.LoadScene("Player2");  
	} 
	public void character2Select() {  
		SceneManager.LoadScene("SampleScene");  
	} 
}  
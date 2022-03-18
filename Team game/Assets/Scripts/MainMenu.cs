using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class MainMenu: MonoBehaviour {  
	public void PlayGame() {  
		SceneManager.LoadScene("SampleScene");  
	} 
	public void doExitGame() {
		Application.Quit();
		Debug.Log("Game is exiting");
		UnityEditor.EditorApplication.isPlaying = false;
	}
}  
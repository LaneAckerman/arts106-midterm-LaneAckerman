using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string Main;
	public string Secondary;
	public string Menu;



	public void PlayGame ()
	{
		SceneManager.LoadScene(Main);

	}

	public void  SecondaryScene ()
	{
		SceneManager.LoadScene(Secondary);

	}

	public void ExitToMenu ()
	{
		SceneManager.LoadScene(Menu);
	}

	public void QuitGame ()
	{
		Debug.Log("Quit!");

		Application.Quit();
	}
}

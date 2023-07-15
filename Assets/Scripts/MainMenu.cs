using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	public string levelToLoad = "RoomLevelSelect";
	public string creditsToLoad = "CreditsScene";

	public SceneFader sceneFader;

	public void Play ()
	{

		sceneFader.FadeTo(levelToLoad);
	}

	public void Credits ()
	{

		sceneFader.FadeTo(creditsToLoad);
	}

	public void Quit ()
	{
		Debug.Log("Exciting...");
		Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
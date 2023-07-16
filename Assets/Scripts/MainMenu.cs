using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "RoomLevelSelect";
    public string creditsToLoad = "CreditsScene";

    public SceneFader sceneFader;
    public MovingCamera movingCamera;

    //MovingCamera script'ine referansta bulun 

    public void Play()
    {
        movingCamera.MoveToCam();
        FindAnyObjectByType<AudioManager>().Play("UIClickSound");
    }

    public void Credits()
    {
        sceneFader.FadeTo(creditsToLoad);
        FindAnyObjectByType<AudioManager>().Play("UIClickSound");
    }

    public void Quit()
    {
        FindAnyObjectByType<AudioManager>().Play("UIClickSound");

        Debug.Log("Exciting...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
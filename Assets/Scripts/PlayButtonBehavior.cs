using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonBehavior : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Battleground");
    }

    public void TutorialExit()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void GoToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

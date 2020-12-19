using UnityEngine;

public class LaunchManager : MonoBehaviour
{
    public GameObject mainMenupanel;
    public GameObject levelSelectPanel;

    void Start()
    {
        mainMenupanel.SetActive(true);
        levelSelectPanel.SetActive(false);
    }

    public void playButton()
    {
        mainMenupanel.SetActive(false);
        levelSelectPanel.SetActive(true);
    }

    public void quitButton()
    {
        Application.Quit();
        Debug.Log("It works");
    }

    public void backButton()
    {
        levelSelectPanel.SetActive(false);
        mainMenupanel.SetActive(true);
    }

    public void level1()
    {
        levelSelectPanel.SetActive(false);

    }
}

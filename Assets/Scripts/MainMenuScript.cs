using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void playbutton()
    {
        SceneManager.LoadScene(1);//File/buildSettings'e girerek oyunumuzun sahne numarasýný öðrendik. Oradaki 1 sayýsý sahne sayýsý.
    }
    public void quitbutton()
    {
        Application.Quit();
    }
}

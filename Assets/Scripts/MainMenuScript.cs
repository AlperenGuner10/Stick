using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void playbutton()
    {
        SceneManager.LoadScene(1);//File/buildSettings'e girerek oyunumuzun sahne numaras�n� ��rendik. Oradaki 1 say�s� sahne say�s�.
    }
    public void quitbutton()
    {
        Application.Quit();
    }
}

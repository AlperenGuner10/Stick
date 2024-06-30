using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    Animator animator;
    public GameObject RotatingBigCircle;
    public GameObject SpawnTransform;
    public void GameOver()
    {
        RotatingBigCircle.GetComponent<RotateBigCircle>().enabled = false;//rotatebigcircle eriþip componenti kapatýyoruz 
        SpawnTransform.GetComponent<SmallStickSpawn>().enabled = false;
    }
}

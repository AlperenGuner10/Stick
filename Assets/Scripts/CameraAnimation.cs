using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(SmallStick.gameFinish == true)
        {
            animator.SetBool("GameOver", true);
        }
    }
}

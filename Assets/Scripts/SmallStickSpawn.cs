using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallStickSpawn : MonoBehaviour
{
    public GameObject smallstick;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StickSpawn();
        }
    }
    void StickSpawn()
    {
        Instantiate(smallstick,transform.position,transform.rotation);
    }
}

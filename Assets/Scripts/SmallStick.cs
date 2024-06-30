using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SmallStick : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public bool ismove;
    public GameObject admin;
    public static bool gameFinish;
    void Start()
    {
        admin = GameObject.FindGameObjectWithTag("Admin");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (ismove == false)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RotatingBigCircle")
        {
            //Küçük çemberi büyük çemberin child'i yaptýk.
            transform.SetParent(collision.transform);
            ismove = true;
        }
        if(collision.gameObject.tag == "SmallCircle")
        {
            gameFinish = true;
            admin.GetComponent<GameEnd>().GameOver();
        }
    }
}

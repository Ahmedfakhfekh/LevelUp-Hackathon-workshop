using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator anim;
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * 10;
            sr.flipX = false;
            anim.SetBool("isRunning",true);
        }
        if (Input.GetKey("q"))
        {
            rb.velocity = Vector2.left * 10;
            sr.flipX = true;
            anim.SetBool("isRunning", true);
        }
        if (Input.GetKeyUp("d") ||  Input.GetKeyUp("q"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isRunning", false);
        }
    }
}

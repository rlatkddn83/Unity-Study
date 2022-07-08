using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    Rigidbody2D robotRd;
    public float walkSpeed = 10.0f;
    public float maxSpeed = 3.0f;
    public float time;
    public bool canJump;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        robotRd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        //float speedx = Mathf.Abs(robotRd.velocity.x);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Walk", true);
            transform.Translate(Vector2.left * walkSpeed*Time.deltaTime);
            //robotRd.AddForce(transform.right * -walkSpeed);
            transform.localScale = new Vector2(-2.0f, 2.0F);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Walk", true);
            transform.Translate(Vector2.right * walkSpeed*Time.deltaTime);
            //robotRd.AddForce(transform.right * walkSpeed);
            transform.localScale = new Vector2(2.0f, 2.0F);
        }
        else
            anim.SetBool("Walk", false);

        if (Input.GetKey(KeyCode.Space) && canJump)
        {
            anim.SetTrigger("JumpT");
            robotRd.velocity = Vector2.up * walkSpeed * 0.5f;
            time = 0;
            canJump = false;

        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }


    
}

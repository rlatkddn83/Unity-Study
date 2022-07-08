using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRd;
    public float speed = 0.0f;

    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        float deg = Random.Range(0, 180);
        Vector3 startSpeed = new Vector3(Mathf.Sin(deg)*speed, 0f, Mathf.Cos(deg) * speed);
        ballRd = GetComponent<Rigidbody>();
        //transform.Translate(-speed*Time.deltaTime, 0f, speed * 0.7f * Time.deltaTime);
        ballRd.velocity = startSpeed;
        //ballRd.AddForce(-speed, 0f, speed*0.7f);

        startPos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        
        //공이 벽에 충돌하면
        if (collision.gameObject.CompareTag("Wall"))
        {
            Vector3 currPos = transform.position;
            Vector3 incomVec = (currPos - startPos).normalized;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec,normalVec);

            ballRd.velocity = reflectVec * speed;
        }

        if (collision.gameObject.CompareTag("Block"))
        {
            Vector3 currPos = transform.position;
            Vector3 incomVec = (currPos - startPos).normalized;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);

            ballRd.velocity = reflectVec * speed;


            Destroy(collision.gameObject);
        }
        startPos = transform.position;
    }
}

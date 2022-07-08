using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBallController : MonoBehaviour
{
    private Rigidbody bowlingBallRd;
    public float speed;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        bowlingBallRd = GetComponent<Rigidbody>();
        bowlingBallRd.AddForce(speed, 0f, 0f);

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
            Vector3 incomVec = currPos - startPos;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);



            bowlingBallRd.AddForce(reflectVec * speed);


            print("shock!");
        }
        startPos = transform.position;
    }

}

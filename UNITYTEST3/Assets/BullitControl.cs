using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullitControl : MonoBehaviour
{
    public float speed;
    public float lifeTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;

        if (lifeTime>3)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            GameObject manager = GameObject.Find("ScoreManager");
            if (collision.collider.name == "Target 1")
            {
                Debug.Log("10point");
                manager.GetComponent<ScoreScript>().IncScore(10);
            }
            else if (collision.collider.name == "Target 2")
            {
                Debug.Log("7point");
                manager.GetComponent<ScoreScript>().IncScore(8);
            }
            else if (collision.collider.name == "Target 3")
            {
                Debug.Log("5point");
                manager.GetComponent<ScoreScript>().IncScore(5);
            }
            else
                manager.GetComponent<ScoreScript>().IncScore(1);

            //manager.GetComponent<ScoreScript>().IncScore();

            Destroy(gameObject);
        }
    }

    public void ShoottoEnemy()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, speed));
    }
    public void ShoottoPlayer()
    {
        GameObject player = GameObject.Find("PLAYER");
        Vector3 dir = player.transform.position - this.transform.position;
        GetComponent<Rigidbody>().AddForce(dir.normalized * speed);

    }
}

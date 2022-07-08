using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody enemyRd;
    public float speed = 0.0f;
    public float min = -1.0f;
    public float max;
    public float turn;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        turn = Random.Range(0.5f, 3.0f);
        enemyRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        max = (-5) * min;
        speed = Random.Range(min, max);
        
        enemyRd.AddForce(speed, 0, 0);
        if(time > turn)
        {
            enemyRd.velocity *= -0.7f;
            min = -min;
            time = 0;
            turn = Random.Range(0.5f, 3.0f);
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "Plane")
        {
            enemyRd.velocity *= -0.5f;
            min = -min;
        }
    }
}

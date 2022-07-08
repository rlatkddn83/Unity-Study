using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUN2Controller : MonoBehaviour
{
    GameObject player;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PLAYER");

    }

    // Update is called once per frame
    void Update()
    {
        dir = this.transform.position - player.transform.position;
        this.transform.rotation = Quaternion.LookRotation(dir);
    }
}

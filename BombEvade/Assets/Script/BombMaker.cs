using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMaker : MonoBehaviour
{
    public GameObject BombPrefab;
    public float interval = 1.0f;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;

        if (time > interval)
        {
            GameObject bomb = Instantiate(BombPrefab);
            int x = Random.Range(-9, 9);
            bomb.transform.position = new Vector2(x, 4);
            time = 0;
        }
    }
}

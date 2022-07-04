using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody playerRd;
    float sppr = 10;
    // Start is called before the first frame update
    void Start()
    {
        // 해당 스크립트가 적용된 오브젝트에서 Rkgkdbody 컴포낸트 생성
        playerRd = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRd.AddForce(-sppr,0f,0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRd.AddForce(sppr,0f,0f);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRd.AddForce(0f,0f, sppr);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRd.AddForce(0f,0f, -sppr);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            playerRd.AddForce(0f, sppr ,0f);
        }
        
    }
}

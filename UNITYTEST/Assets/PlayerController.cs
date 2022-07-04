using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        print("Start!");

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update!!");

        // vector3 타입으로 벡터의 방향과 속도로 오브젝트 이동
        // DeltaTime은 컴퓨터의 성능에 따라 속도가 일정하도록 프레임 시간간격을 동기화 하는것
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}

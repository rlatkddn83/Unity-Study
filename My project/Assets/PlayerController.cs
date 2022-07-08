using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        //print("Start!");

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update!!");

        // vector3 Ÿ������ ������ ����� �ӵ��� ������Ʈ �̵�
        // DeltaTime�� ��ǻ���� ���ɿ� ���� �ӵ��� �����ϵ��� ������ �ð������� ����ȭ �ϴ°�
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Rotate(0, speed * 15 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Rotate(0, -speed * 15 * Time.deltaTime, 0);
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

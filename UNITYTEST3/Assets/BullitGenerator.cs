using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullitGenerator : MonoBehaviour
{
    public GameObject bullitPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //�������� �̿��ؼ� ������Ʈ(�Ѿ�)�� ����
            GameObject bullet = Instantiate(bullitPrefab, transform.position, transform.rotation);
            //BullitControl���� Shoot()�� ȣ��
            bullet.GetComponent<BullitControl>().ShoottoEnemy();

        }
    }


}

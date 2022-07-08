using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullitGenerator2 : MonoBehaviour
{
    public GameObject bullitPrefab;
    private float time = 0.0f;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        this.time += Time.deltaTime;

        if (this.time > 0.1f && count < 3)
        {
            Shoot();
            this.time = 0.0f;
            count++;
        }

        if (this.time > 1.0f)
        {
            this.time = 0.0f;
            count = 0;
        }
    }

    public void Shoot()
    {
        //�������� �̿��ؼ� ������Ʈ(�Ѿ�)�� ����
        GameObject bullet = Instantiate(bullitPrefab, transform.position, transform.rotation);
        //BullitControl���� Shoot()�� ȣ��
        bullet.GetComponent<BullitControl>().ShoottoPlayer();
    }


}

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
            //프리팹을 이용해서 오브젝트(총알)을 생성
            GameObject bullet = Instantiate(bullitPrefab, transform.position, transform.rotation);
            //BullitControl에서 Shoot()을 호출
            bullet.GetComponent<BullitControl>().ShoottoEnemy();

        }
    }


}

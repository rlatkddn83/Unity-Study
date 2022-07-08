using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HpControl : MonoBehaviour
{
    GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("Hp");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HpMinus()
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f;
        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

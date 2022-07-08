using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private Text score;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("Score").GetComponent<Text>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncScore(int x)
    {
        count += x;
        this.score.text = count.ToString();
    }
}

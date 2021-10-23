using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText; //Text variable to show the score 
    private float score; // count score 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")!=null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString("Score: 0");
        }
    }
}

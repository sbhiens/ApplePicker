using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
   
    public Text scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
       // scoreText = GetComponent<Text>();
      //  scoreText.text = score.ToString("#,0");
    }

    // Update is called once per frame
     void Update()
    {
         
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Scoretext; 
    static int score=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.text="Score " + score.ToString();
    }
    public void SetScore(int score1)
    {
        score = score1; 
    }
    public int GetScore()
    {
        return score;
    }
}

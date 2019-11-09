using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int environnementScore;
    public int opinionScore;
    public int dayScore;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementDayScore()
    {
        dayScore++;
    }
    public void UpdateEnvironnementScore(int Score)
    {
        environnementScore += Score;
        UIManager.instance.updateEnvironnementText(environnementScore);
    }
    public void UpdateOpinionScore(int Score)
    {
        opinionScore += Score;
        UIManager.instance.updateOpinionText(opinionScore);
    }
}

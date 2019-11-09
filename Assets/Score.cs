using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int environnementScore;
    public int opinionScore;
    public int dayScore;
    private Text envScore;
    // Start is called before the first frame update
    void Start()
    {
        envScore = GameObject.Find("Canvas/EnvironnementText").GetComponent<Text>();
        environnementScore = 50;
        opinionScore = 50;
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
        envScore.text = ($"Environnement : {environnementScore.ToString()}");
    }
    public void UpdateOpinionScore(int Score)
    {
        opinionScore += Score;
        envScore.text = ($"Opinion publique : {opinionScore.ToString()}");
    }
}

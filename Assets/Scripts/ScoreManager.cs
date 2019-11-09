using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float environnementScore;
    public float opinionScore;
    public float dayScore;

    public static ScoreManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        opinionScore = 50;
        environnementScore = 50;
        dayScore = 50;

        instance = this;
    }
    void Start()
    {
        UIManager.instance.UpdateEnvironnementText(environnementScore);
        UIManager.instance.UpdateOpinionText(opinionScore);
        UIManager.instance.UpdateScoreText(dayScore);
    }

    /// <summary>
    /// Accepte un tas de déchet
    /// </summary>
    public void Accept()
    {
        var ecologyDetritusScore = GameManager.instance.currentDetritus.content.acceptInfluence.ecology;
        var ecologyBackstoryScore = GameManager.instance.currentCharacter.data.backStory.acceptInfluence.ecology;
        UpdateEnvironnementScore(ecologyDetritusScore + ecologyBackstoryScore);
        var opinionPublicDetritusScore = GameManager.instance.currentDetritus.content.acceptInfluence.publicOpinion;
        var opinionPublicBackstoryScore = GameManager.instance.currentCharacter.data.backStory.acceptInfluence.publicOpinion;
        UpdateOpinionScore(opinionPublicDetritusScore + opinionPublicBackstoryScore);
        GameManager.instance.ThrowDetritus();
    }

    /// <summary>
    /// Refuse le tas de dechet
    /// </summary>
    public void Reject()
    {
        var ecologyDetritusScore = GameManager.instance.currentDetritus.content.rejectInfluence.ecology;
        var ecologyBackstoryScore = GameManager.instance.currentCharacter.data.backStory.rejectInfluence.ecology;
        UpdateEnvironnementScore(ecologyDetritusScore + ecologyBackstoryScore);
        var opinionPublicDetritusScore = GameManager.instance.currentDetritus.content.rejectInfluence.publicOpinion;
        var opinionPublicBackstoryScore = GameManager.instance.currentCharacter.data.backStory.rejectInfluence.publicOpinion;
        UpdateOpinionScore(opinionPublicDetritusScore + opinionPublicBackstoryScore);

        GameManager.instance.ThrowDetritus();
    }

    public void IncrementDayScore()
    {
        dayScore++;
    }
    public void UpdateEnvironnementScore(float score)
    {
        environnementScore += score;
        UIManager.instance.UpdateEnvironnementText(environnementScore);
    }
    public void UpdateOpinionScore(float score)
    {
        opinionScore += score;
        UIManager.instance.UpdateOpinionText(opinionScore);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Image bubbleZoom;
    public Image bagContent;

    public Button AcceptButton;
    public Button RefuseButton;

    public Text EnvironnementText;
    public Text OpinionText;
    public Text ScoreDayText;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    
    public void PopDetritusZoom(BagData bag, bool show)
    {
        Debug.Log("Popup");
        bubbleZoom.gameObject.SetActive(show);
        bagContent.gameObject.SetActive(show);
        bagContent.sprite = bag.sprite;
        AcceptButton.gameObject.SetActive(show);
        RefuseButton.gameObject.SetActive(show);
    }



    public void UpdateEnvironnementText(float value)
    {
        EnvironnementText.text = ($"Environnement : {value.ToString()}");
    }
    public void UpdateOpinionText(float value)
    {
        OpinionText.text = ($"Opinion publique : {value.ToString()}");
    }
    public void UpdateScoreText(float value)
    {
        ScoreDayText.text = ($"Score : {value.ToString()}");
    }
}

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
    void Start()
    {
        instance = this;
    }
    
    public void PopDetritusZoom(BagData bag)
    {
        Debug.Log("Popup");
        bubbleZoom.gameObject.SetActive(true);
        bagContent.gameObject.SetActive(true);
        bagContent.sprite = bag.sprite;
        AcceptButton.gameObject.SetActive(true);
        RefuseButton.gameObject.SetActive(true);
    }

    public void Accept()
    {

    }

    public void updateEnvironnementText(int value)
    {
        EnvironnementText.text = ($"Environnement : {value.ToString()}");
    }
    public void updateOpinionText(int value)
    {
        OpinionText.text = ($"Opinion publique : {value.ToString()}");
    }
    public void updateScoreText(int value)
    {
        ScoreDayText.text = ($"Score : {value.ToString()}");
    }
}

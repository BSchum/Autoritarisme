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

}

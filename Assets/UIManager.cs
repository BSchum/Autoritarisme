using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Image bubbleZoom;
    public Image bagContent;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    
    public void PopDetritusZoom(Bag bag)
    {
        Debug.Log("Popup");
        bubbleZoom.gameObject.SetActive(true);
        bagContent.gameObject.SetActive(true);
        bagContent.sprite = bag.sprite;
    }
}

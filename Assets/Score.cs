using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int environnement;
    // Start is called before the first frame update
    void Start()
    {
        Text envScore = GameObject.Find("Canvas/EnvironnementText").GetComponent<Text>();
        envScore.text = "test";
        environnement = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

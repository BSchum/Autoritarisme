using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject currentDetritus;
    public Transform scanPosition;
    public float speed = 2f;
    bool detritusInScan;
    public bool isScanning;

    public static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        var direction = scanPosition.position - currentDetritus.transform.position;

        if (direction.magnitude > 0)
        {
            currentDetritus.transform.position = Vector3.MoveTowards(currentDetritus.transform.position, scanPosition.position, Time.deltaTime * speed);
        }
        else if(!isScanning && direction.magnitude <= 0)
        {
            Scan();
        }
    }

    void Scan()
    {
        isScanning = true;
        Debug.Log("Je scanne le detritus");
    }
}

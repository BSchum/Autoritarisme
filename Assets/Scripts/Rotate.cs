using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        if(!GameManager.instance.isScanning)
            this.transform.Rotate(new Vector3(0, 0, rotateSpeed));
    }
}

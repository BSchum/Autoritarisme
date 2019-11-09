using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Character> characters;
    public Character currentCharacter;
    public Detritus currentDetritus;

    public Detritus detritusPrefab;

    
    public Transform detritusSpawn;
    public Transform playerSpawn;
    public Transform scanPosition;
    public Transform endConvoyerPosition;
    public float speed = 2f;
    public bool isScanning;
    public bool isThrowing;

    enum ConvoyerState
    {
        Throwing,
        Scanning,
        Waiting
    }

    ConvoyerState convoyerState = ConvoyerState.Waiting;

    public static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    private void Awake()
    {
        SetUpNewCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        var directionToScan = scanPosition.position - currentDetritus.transform.position;
        var directionToEnd = endConvoyerPosition.position - currentDetritus.transform.position;

        if (directionToScan.magnitude > 0 && convoyerState == ConvoyerState.Waiting)
        {
            MoveDetritusTowardDestination(scanPosition);
        }
        else if(directionToScan.magnitude == 0 && convoyerState == ConvoyerState.Waiting)
        {
            convoyerState = ConvoyerState.Scanning;
            Scan();
        }
        else if (directionToEnd.magnitude > 0 && convoyerState == ConvoyerState.Throwing)
        {
            MoveDetritusTowardDestination(endConvoyerPosition);
        }
        else if(directionToEnd.magnitude == 0 && convoyerState == ConvoyerState.Throwing)
        {
            Destroy(currentCharacter.gameObject);
            Destroy(currentDetritus.gameObject);
            convoyerState = ConvoyerState.Waiting;
            SetUpNewCharacter();
        }
    }
    public void MoveDetritusTowardDestination(Transform destination)
    {
        currentDetritus.transform.position = Vector3.MoveTowards(currentDetritus.transform.position, destination.position, Time.deltaTime * speed);
    }
    public void ThrowDetritus()
    {
        convoyerState = ConvoyerState.Throwing;
        var bag = currentDetritus.GetComponent<Detritus>().content;
        UIManager.instance.PopDetritusZoom(bag, false);

    }

    void Scan()
    {
        isScanning = true;
        var bag = currentDetritus.GetComponent<Detritus>().content;
        UIManager.instance.PopDetritusZoom(bag, true);
    }

    

    void SetUpNewCharacter()
    {
        //On crée un personnage au hasard
        currentCharacter = Instantiate(characters[UnityEngine.Random.Range(0, characters.Count)], playerSpawn.position, Quaternion.identity);
        currentCharacter.data.ChooseRandomBag();
        //On pose le détritu sur la table
        currentDetritus = Instantiate(detritusPrefab, detritusSpawn.position, Quaternion.identity);
        currentDetritus.content = currentCharacter.data.bag;
    }
}

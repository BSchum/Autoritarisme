using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterData data;

    public void Start()
    {
        GetComponentInChildren<SpriteRenderer>().sprite = data.sprite;
        data.ChooseRandomBag();
    }
}

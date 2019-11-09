﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName ="Assets/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public Sprite sprite;
    [TextArea]
    public string backStory;
    public List<BagData> availableBags;
    public BagData bag;
    public Influence influence;


    public void ChooseRandomBag()
    {
        int bagIndex = Random.Range(0, availableBags.Count);
        bag = availableBags[bagIndex];
    }
}

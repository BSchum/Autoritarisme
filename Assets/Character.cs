using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Assets/Character")]
public class Character : ScriptableObject
{

    public string characterName;
    [TextArea]
    public string backStory;
    public List<Bag> availableBags;
    public Bag bag;


    public void ChooseRandomBag()
    {
        int bagIndex = Random.Range(0, availableBags.Count);
        bag = availableBags[bagIndex];
    }
}

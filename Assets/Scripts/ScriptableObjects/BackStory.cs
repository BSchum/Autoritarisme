using UnityEngine;

[CreateAssetMenu(menuName = "Assets/BackStory")]
public class BackStory : ScriptableObject
{
    [TextArea]
    public string backStory;
    public Influence acceptInfluence;
	public Influence rejectInfluence;
}
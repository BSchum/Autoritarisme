using UnityEngine;

[CreateAssetMenu(menuName = "Assets/BagData")]
public class BagData : ScriptableObject
{
    public Sprite sprite;
    public Influence acceptInfluence;
    public Influence rejectInfluence;
}
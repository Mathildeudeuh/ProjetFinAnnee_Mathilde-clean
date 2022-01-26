using UnityEngine;

[CreateAssetMenu]
public class ItemsAddTime : ScriptableObject
{
    public void AddTime()
    {
        
        var itemTime = FindObjectOfType<Timer>();
        itemTime.seconde += itemTime.addTime;
    }
}
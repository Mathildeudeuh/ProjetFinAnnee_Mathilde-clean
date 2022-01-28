using UnityEngine;

public class ItemsAddTime : TimerBehaviour
{
    public void AddTime()
    {
        secondeSO.seconde += secondeSO.seconde;
    }
}
using UnityEngine;

public class ItemsAddTime : TimerBehaviour
{
    private TimerBehaviour timer;
    public void AddTime()
    {
        seconde += seconde;
    }
}
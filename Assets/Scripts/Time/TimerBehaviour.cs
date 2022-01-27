using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBehaviour : MonoBehaviour
{
    public bool onTrigger;
    public float seconde;

    void Update()
    {
        if (onTrigger == false)
        {
            seconde -= Time.deltaTime;
        }
    }
}
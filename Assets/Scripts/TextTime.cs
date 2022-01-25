using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTime : TimerBehaviour
{
    [SerializeField] Text myText;
    void Start()
    {
        myText.text = Mathf.Round(seconde).ToString();

    }

    void Update()
    {
        
    }
}

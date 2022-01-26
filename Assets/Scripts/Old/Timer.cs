using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float seconde;
    public float addTime;
    public bool onTrigger;

    [SerializeField] private Text myText;

    void Update()
    {
        var end = FindObjectOfType<GameOver>();

        if (onTrigger == false)
        {
            seconde -= Time.deltaTime;

            myText.text = Mathf.Round(seconde).ToString();
            
            end.EndOfTheGame();
        }

        else
        {
            myText.text = Mathf.Round(seconde).ToString();
            onTrigger = false;
        }
    }
}
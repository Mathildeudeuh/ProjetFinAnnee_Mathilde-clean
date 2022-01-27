using UnityEngine;
using UnityEngine.UI;

public class TextTime : TimerBehaviour
{
    [SerializeField] Text myText;

    void Update()
    {
        myText.text = Mathf.Round(seconde).ToString();
    }
}
using UnityEngine;
using TMPro;

public class TextTime : TimerBehaviour
{
    [SerializeField] private TextMeshProUGUI myText;

    public void ShowTime()
    {
        myText.text = Mathf.Round(seconde).ToString();
    }
}
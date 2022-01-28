using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
    public float seconde;
    public float addTime;
    public bool onTrigger;

    [SerializeField] private TextMeshProUGUI myText;

    private void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        var end = FindObjectOfType<GameOver>();

        if (onTrigger == false)
        {
            seconde -= Time.deltaTime;

            myText.text = Mathf.Round(seconde).ToString();
        }

        else
        {
            myText.text = Mathf.Round(seconde).ToString();
            onTrigger = false;
        }
    }
}
using UnityEngine;
//using UnityEngine.Events;

public class TimerBehaviour : MonoBehaviour
{
    public bool onTrigger;
    public float seconde;
    private TextTime textTime;
    private ItemsAddTime addTime;
    private GameOver gameOver;
    //public UnityEvent endTimeEvent;

    private void Start()
    {
        textTime = GetComponent<TextTime>();
        gameOver = GetComponent<GameOver>();
        addTime = GetComponent<ItemsAddTime>();
    }

    void Update()
    {
        if (onTrigger == false)
        {
            seconde -= Time.deltaTime;
            textTime.ShowTime();

            if (seconde <= 0)
            {
                gameOver.EndOfTheGame();
            }
        }

        else if (onTrigger == true)
        {
            addTime.AddTime();
        }
    }
}
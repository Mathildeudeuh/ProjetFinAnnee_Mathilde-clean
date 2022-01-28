using UnityEngine;

public class TimerBehaviour : MonoBehaviour
{
    public bool onTrigger;
    public SecondeSO secondeSO;
    protected float newTime;
    private TextTime textTime;

    private void Start()
    {
        textTime = GetComponent<TextTime>();
    }

    void Update()
    {
        if (onTrigger == false)
        {
            newTime = secondeSO.seconde -= Time.deltaTime;
            textTime.ShowTime();
        }

        if (newTime == 0)
        {
            //UNITY EVENT
        }
    }
}
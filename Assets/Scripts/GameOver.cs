using UnityEngine;
using UnityEngine.Events;

public class GameOver : TimerBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject scene;
    private UnityEvent endTime;


    public void EndOfTheGame()
    {
        if (secondeSO.seconde <= 0)
        {
            gameOver.SetActive(true);
            scene.SetActive(false);
            endTime.Invoke();
        }
    }
}
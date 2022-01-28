using UnityEngine;

public class GameOver : TimerBehaviour
{
    [SerializeField] GameObject gameOverEnd;
    [SerializeField] GameObject scene;

    public void EndOfTheGame()
    {
        gameOverEnd.SetActive(true);
        scene.SetActive(false);
    }
}
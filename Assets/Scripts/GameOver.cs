using UnityEngine;

public class GameOver : Timer
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject scene;

    public void EndOfTheGame()
    {
        if (seconde <= 0)
        {
            gameOver.SetActive(true);
            scene.SetActive(false);
        }
    }
}
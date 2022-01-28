using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject scene;

    public void EndOfTheGame()
    {
        var endTime = FindObjectOfType<Timer>();

            if (endTime.seconde <= 0)
            {
                gameOver.SetActive(true);
                scene.SetActive(false);
            }
    }
}
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener<T> : MonoBehaviour
{
    public UnityEvent<T> endTimeEvent;
    public GameEvent<T> myEvent;

    private void OnEnable()
    {
        myEvent.AddListener(this);
    }

    private void OnDisable()
    {
        myEvent.RemoveListener(this);
    }

    public void OnEventRaised(T value)
    {
        endTimeEvent.Invoke(value);
    }
}
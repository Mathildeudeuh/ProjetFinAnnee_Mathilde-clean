using UnityEngine;

[CreateAssetMenu]
public class Temp : MonoBehaviour
{
    public GameEvent customEvent;
    public StringGameEvent stringGEWithParameter;


    void Start()
    {
        var objectName = transform.name;
       // stringGEWithParameter.Raise(objectName);
    }

    void Update()
    {
        //customEvent.Raise();
    }
}

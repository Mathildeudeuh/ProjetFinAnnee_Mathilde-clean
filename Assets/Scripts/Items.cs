using UnityEngine;


[RequireComponent(typeof(ItemsAddTime))]
[RequireComponent(typeof(Timer))]

public class Items : MonoBehaviour
{
    [SerializeField] public GameObject star;
    private ItemsAddTime addTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        star.SetActive(false);
        addTime.AddTime();
    }

    //public void AddTime();
}
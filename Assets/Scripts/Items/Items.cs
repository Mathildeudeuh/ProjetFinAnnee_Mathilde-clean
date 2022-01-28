using UnityEngine;


[RequireComponent(typeof(ItemsAddTime))]

public class Items : MonoBehaviour
{
    [SerializeField] public GameObject star;
    public ItemsAddTime addTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        star.SetActive(false);
        addTime.AddTime();
    }
}
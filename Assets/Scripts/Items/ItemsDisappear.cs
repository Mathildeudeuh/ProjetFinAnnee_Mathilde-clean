using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsDisappear : MonoBehaviour
{
    [SerializeField] public GameObject star;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        star.SetActive(false);
    }
}
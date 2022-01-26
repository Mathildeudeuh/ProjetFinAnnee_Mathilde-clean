using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    protected Rigidbody2D body2D;

    void Awake()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    public abstract void Move2D(Vector2 moveLR);
}
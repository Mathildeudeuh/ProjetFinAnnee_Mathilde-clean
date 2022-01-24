using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public override void Move2D()
    {
        body2D.AddForce(new Vector2(speed * moveLR, 0));

    }

};
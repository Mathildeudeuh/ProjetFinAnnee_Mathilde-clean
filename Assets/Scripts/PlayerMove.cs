using UnityEngine;

public class PlayerMove : Mover
{
    private float maxSpeed;
    private float speed;

    public override void Move2D(Vector2 moveLR)
    {
        if (body2D.velocity.sqrMagnitude < maxSpeed)
        body2D.AddForce(new Vector2(speed * moveLR.x, 0));
    }
}
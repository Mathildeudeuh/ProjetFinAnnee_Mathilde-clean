using UnityEngine;

public class AddForceMove : Mover
{
    public float maxSpeed;
    public SpeedSO speedSO;

    public override void Move2D(Vector2 moveLR)
    {
        if (body2D.velocity.sqrMagnitude < maxSpeed)
        body2D.AddForce(new Vector2(speedSO.speed * moveLR.x, 0));
    }
}
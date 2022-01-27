using UnityEngine;

public class Raycast : Jump
{
    private LayerMask layer;

    void Update()
    {
        var touch = Physics2D.Raycast(transform.position, new Vector2(0, -1), 0.55f, layer);

        if (touch.collider != null)
        {
            canJump = true;
        }

        else
        {
            canJump = false;
        }
    }
}
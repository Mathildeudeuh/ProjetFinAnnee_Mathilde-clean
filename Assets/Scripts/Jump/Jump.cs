using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D body2D;
    public bool canJump {get; protected set; }
    public JumpForceSO jumpForce;

    private void Awake()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

    public void Jumping()
    {
        if (canJump == true)
        {
            body2D.AddForce(new Vector2(0, jumpForce.jumpForceValue), ForceMode2D.Impulse);
        }
    }
}
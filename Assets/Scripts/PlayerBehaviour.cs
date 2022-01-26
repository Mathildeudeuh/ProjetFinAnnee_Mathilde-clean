using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    private PlayerMove playerMove;
    private Vector2 moveLR;
    private Rigidbody2D body2D;
    private SpriteRenderer sprite;
    public PlayerAnimations animations;
    private PlayerJump playerJump;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        playerMove = GetComponent<PlayerMove>();
    }

    public void MoveOnPerformed(InputAction.CallbackContext obj)
    {
        moveLR = obj.ReadValue<Vector2>();
        if (!obj.performed)
            return;
        animations.MoveOnPerformed(moveLR);
        sprite.flipX = (moveLR.x < 0);
  
    }

    private void FixedUpdate()
    {
        // Faire le Move
        playerMove.Move2D();

    }

    public void JumpOnPerformed(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        animations.MoveOnPerformed(moveLR);
        //playerJump.Jumping();
    }
}
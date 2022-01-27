using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(AddForceMove))]
[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(PlayerAnimations))]
[RequireComponent(typeof(Jump))]
public class PlayerBehaviour : MonoBehaviour
{
    private AddForceMove addForceMove;
    private Vector2 moveLR;
    private Rigidbody2D body2D;
    private SpriteRenderer sprite;
    public PlayerAnimations animations;
    private Jump jump;

    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        addForceMove = GetComponent<AddForceMove>();
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
        addForceMove.Move2D(moveLR);

    }

    public void JumpOnPerformed(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        animations.MoveOnPerformed(moveLR);
        jump.Jumping();
    }
}
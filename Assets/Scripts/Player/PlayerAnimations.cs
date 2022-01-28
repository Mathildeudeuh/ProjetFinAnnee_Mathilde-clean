using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void MoveOnPerformed(Vector2 moveLR)
    {

        animator.SetFloat("Speed", moveLR.x);
    }

    public void JumpOnPerformed()
    {
        animator.SetBool("Jump", true);
    }
}

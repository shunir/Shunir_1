using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float gravity = 20f;

    private float jumpVelocity = 0f;
    private float jumpHeight = 0f;
    private bool isJumping = false;

    private Vector3 basePosition;

    Animator animator;

    void Start()
    {
        basePosition = transform.position;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 이동
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        animator.SetFloat("MoveX", moveX);
        animator.SetFloat("MoveY", moveY);

        Vector3 move = new Vector3(moveX, moveY, 0).normalized;
        basePosition += move * moveSpeed * Time.deltaTime;

        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            jumpVelocity = jumpForce;
        }

        if (isJumping)
        {
            jumpHeight += jumpVelocity * Time.deltaTime;
            jumpVelocity -= gravity * Time.deltaTime;

            if (jumpHeight <= 0f)
            {
                jumpHeight = 0f;
                isJumping = false;
            }
        }


        transform.position = basePosition + new Vector3(0, jumpHeight, 0);
    }


}

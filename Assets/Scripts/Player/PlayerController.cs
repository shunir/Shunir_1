using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float gravity = 20f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private float jumpVelocity = 0f;
    private float jumpHeight = 0f;
    private bool isJumping = false;

    private Vector3 basePosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 이동
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");


        Vector3 move = new Vector3(moveX, moveY, 0).normalized;
        basePosition += move * moveSpeed * Time.deltaTime;

        transform.position = basePosition;

        bool isMoving = (moveX != 0 || moveY != 0);
        animator.SetBool("IsMove", isMoving); // <- Animator에 "IsMove" bool 타입 있어야 함

        // Sprite 좌우 반전 (오른쪽일 때 false, 왼쪽일 때 true)
        if (moveX < 0)
            spriteRenderer.flipX = true;
        else if (moveX > 0)
            spriteRenderer.flipX = false;


        transform.position = basePosition + new Vector3(0, jumpHeight, 0);

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            jumpVelocity = jumpForce;
        }

        // 점프 물리 처리
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 벽에 닿았을 때 벽 뚫림 방지
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("벽에 부딪혔습니다. 더 이상 뚫고 나가지 않습니다.");

            Vector2 contactPoint = collision.GetContact(0).point; 
            Vector2 normal = collision.GetContact(0).normal;

            Vector2 overlapVector = (Vector2)rb.position - contactPoint;
            float overlapMagnitude = overlapVector.magnitude;

            rb.position += normal * (overlapMagnitude + 0.01f);
        }

        
        isJumping = false;
    }





}





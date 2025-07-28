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
        // �̵�
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");


        Vector3 move = new Vector3(moveX, moveY, 0).normalized;
        basePosition += move * moveSpeed * Time.deltaTime;

        transform.position = basePosition;

        bool isMoving = (moveX != 0 || moveY != 0);
        animator.SetBool("IsMove", isMoving); // <- Animator�� "IsMove" bool Ÿ�� �־�� ��

        // Sprite �¿� ���� (�������� �� false, ������ �� true)
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

        // ���� ���� ó��
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
        // ���� ����� �� �� �ո� ����
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("���� �ε������ϴ�. �� �̻� �հ� ������ �ʽ��ϴ�.");

            Vector2 contactPoint = collision.GetContact(0).point; 
            Vector2 normal = collision.GetContact(0).normal;

            Vector2 overlapVector = (Vector2)rb.position - contactPoint;
            float overlapMagnitude = overlapVector.magnitude;

            rb.position += normal * (overlapMagnitude + 0.01f);
        }

        
        isJumping = false;
    }





}





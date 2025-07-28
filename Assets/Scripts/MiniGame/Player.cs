using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    Animator animator = null;
    Rigidbody2D _rigidbody = null;
    GameManager gameManager = null;

    public float flapForce = 6f;
    public float forwardSpeed = 3f;
    public bool isDead = false;
    float deathCooldown = 0f;




    bool isFlap = false;


    public bool godMode = false;


    void Start()
    {
        animator = transform.GetComponentInChildren<Animator>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();
        gameManager = GameManager.Instance;

        if (animator == null)
        { 
         Debug.LogError("Not Founded Animator");
        }

        if (_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }



    void Update()
    {
        if (isDead)
        {
            if (deathCooldown <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    
                }

            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                isFlap = true;
            }
        }
    }

    public void FixedUpdate()
    {
        if (isDead)
            return;
        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isFlap)
        {
            velocity.y = flapForce;
            isFlap = false;
        }
        
        _rigidbody.velocity = velocity;

        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10f), -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (godMode)
            return;


        animator.SetInteger("IsDie", 1);
        isDead = true;
        deathCooldown = 1f;

        GameManager.Instance.GameOver();
    }


    public void StopPlayer()
    {
        isDead = true;
        forwardSpeed = 0f;
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0f; // 회전 속도 제거
        _rigidbody.isKinematic = true;
        _rigidbody.freezeRotation = true; // 회전 자체 막기
        animator.SetInteger("IsDie", 1);
        animator.SetBool("isDead", true);
    }

    public void ResetPlayer()
    {
        isDead = false;
        deathCooldown = 0f;
        transform.position = Vector3.zero; // 시작 위치로 리셋
        transform.rotation = Quaternion.identity;
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.isKinematic = false; // 다시 물리 작동
        _rigidbody.freezeRotation = false; // 회전 제한 해제

        animator.SetInteger("IsDie", 0); // 애니메이션 상태도 초기화
    }
}


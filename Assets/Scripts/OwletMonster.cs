using System;
using JetBrains.Annotations;
using UnityEngine;

public class OwletMonster : MonoBehaviour
{
    public float currentDashCD = 5f;
    public float dashCD = 1f;
    public float dashSpeed = 1f;
    
    public AudioClip JumpSound;
    public AudioSource JumpingSoundSource;
    public AudioSource WalkingSoundSource;
    public LayerMask
        layerMask;
    public GameObject OwletPrefab;
    public Rigidbody2D rb;
    public float speed = 2f;
    public int number = 4;
    public Transform GroundChecker;
    public float GroundCheckRadius; 
    public float jumpForce = 10f;
    public int MaxJumps = 2;
    private int CurrentJumps = 0;
    private void Update()
    {
        Vector2 movement = rb.linearVelocity;
        if (Input.GetKey(KeyCode.A) || TouchButton.isLeftPressed) 
        {
             movement.x = -speed;
             transform.localScale = new Vector3 (-1, 1, 1);
        }

        else if (Input.GetKey(KeyCode.D) || TouchButton.isRightPressed)
        {
             movement.x = +speed;
            transform.localScale = new Vector3(1, 1, 1);
        }

        if ((Input.GetKeyDown(KeyCode.Space) || TouchButton.isJumpPressed) && CanJump())
        {
             movement.y = jumpForce;
             JumpingSoundSource.PlayOneShot(JumpSound);
            
        }
        rb.linearVelocity = (movement);
        if (movement.magnitude > 0.1f && Isgrounded())
        {
            WalkingSoundSource.volume = 1f;
        }
        else
        {
            WalkingSoundSource.volume = 0f;
        }

        if (Input.GetKeyDown(KeyCode.E) && currentDashCD <= 0 )
        {
            
        float xInput = transform.localScale.x;
        rb.linearVelocityX = (dashSpeed * xInput);
        currentDashCD = dashCD;

        }

        if (currentDashCD < 0)
        {
            currentDashCD = 0; return;
        }
        else
        {
            currentDashCD -= Time.deltaTime;
        }
        
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(GroundChecker.position, GroundCheckRadius);
        
    }

    void Start()
    {
    }



    private bool Isgrounded()
    {
        return Physics2D.OverlapCircle(GroundChecker.position,
            GroundCheckRadius,layerMask);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (Isgrounded())
        {
            CurrentJumps = 0;
        }
    }

    private bool CanJump()
    {
        if (CurrentJumps < MaxJumps)
        {
            CurrentJumps++; 
            return true;
        }
        else
        {
            return false;
        }

    }
}

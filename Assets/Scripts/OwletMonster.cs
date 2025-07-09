using System;
using UnityEngine;

public class OwletMonster : MonoBehaviour
{
    public LayerMask
        layerMask;
    public GameObject OwletPrefab;
    public Rigidbody2D rb;
    public float speed = 2f;
    public int number = 4;
    public Transform GroundChecker;
    public float GroundCheckRadius; 
    public float jumpForce = 10f;

    private void Update()
    {
        Vector2 movement = rb.linearVelocity;
        if (Input.GetKey(KeyCode.A))
        {
             movement.x = -speed;
             transform.localScale = new Vector3 (-1, 1, 1);
        }

        else if (Input.GetKey(KeyCode.D))
        {
             movement.x = +speed;
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKey(KeyCode.Space) && Isgrounded())
        {
             movement.y = jumpForce;
            
        }
        rb.linearVelocity = (movement);
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
}

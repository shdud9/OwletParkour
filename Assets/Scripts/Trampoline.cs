using System;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpForce = 10f;
    //видали не потрібний метод
    void Start()
    {
        
    }
    
    //видали не потрібний метод

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>()
                .linearVelocityY = jumpForce;



        }
        
        
    }
}

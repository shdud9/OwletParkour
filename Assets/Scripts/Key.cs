using System;
using UnityEngine;

public class Key : MonoBehaviour
{
    
    public Door door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        door.key = true;
        door.collider.isTrigger = true;
        Destroy(gameObject);
    }
}

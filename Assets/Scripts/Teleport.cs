using System;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleport_point;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = teleport_point.position;  
    }
}

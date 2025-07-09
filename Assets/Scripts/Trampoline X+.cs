using UnityEngine;

public class TrampolineXY : MonoBehaviour
{
    private float Speed = 10f;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>()
                .linearVelocityX = +Speed;
        }
    }
}

        

using UnityEngine;

public class TrampolineX : MonoBehaviour
{
    public float Speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>()
                .linearVelocityX = -Speed;
        }
    }
}

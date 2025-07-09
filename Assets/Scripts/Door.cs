using UnityEngine;

public class Door : MonoBehaviour
{
    public Collider2D collider;
    public SpriteRenderer spriteRenderer;  
    public bool key = false; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (key)
        {
        spriteRenderer.color = Color.gray;    
        }
    }
}

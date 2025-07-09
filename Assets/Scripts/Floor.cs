using System;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public FloorColor floorColor;
    public SpriteRenderer spriteRenderer;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (floorColor == FloorColor.blue)
        {
            spriteRenderer.color = Color.blue;
        }
        else if (floorColor == FloorColor.green)
        {
            spriteRenderer.color = Color.green;
        }
        else if (floorColor == FloorColor.red)
        {
            spriteRenderer.color = Color.red;
        }
        else if (floorColor == FloorColor.yellow)
        {
            spriteRenderer.color = Color.yellow;
        }
        else if (floorColor == FloorColor.pink)
        {
            spriteRenderer.color = new Color(1f, 0.4f, 0.7f );
        }
        else if (floorColor == FloorColor.purple)
        {
            spriteRenderer.color = new Color(0.5f, 0f, 0.5f );
        }
        else
        {
            spriteRenderer.color = new Color(1f, 0.5f, 0f);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        spriteRenderer.color = Color.white;
    }
}

public enum FloorColor
{
    red,blue,green,yellow,orange,purple,pink
}
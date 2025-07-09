using System;
using TMPro;
using UnityEngine;

public class ConsoleWithTrampoline : MonoBehaviour
{
    public TextMeshProUGUI TrampoText;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        TrampoText.text = "Игрок прыгнул!"; 
        Debug.Log("Игрок прыгнул!");
    }
}

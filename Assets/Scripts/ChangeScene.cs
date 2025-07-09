using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private string LevelSave = "LevelSave";
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
            int LevelSaveInt = PlayerPrefs.GetInt(LevelSave, 1);
            LevelSaveInt += 1;
            PlayerPrefs.SetInt(LevelSave, LevelSaveInt);
            SceneManager.LoadScene("LvL" + LevelSaveInt);
            
        }
        
        
    }
}

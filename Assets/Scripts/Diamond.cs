using UnityEngine;

public class Diamond : MonoBehaviour
{
    private int diamonds;
    string key = "diamonds";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        PlayerPrefs.SetInt(key, 1);  
        diamonds = PlayerPrefs.GetInt(key, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

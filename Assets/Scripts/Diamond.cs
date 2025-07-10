using UnityEngine;

public class Diamond : MonoBehaviour
{
    private int diamonds;
    string key = "diamonds";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        int diamondsAmount = PlayerPrefs.GetInt(diamonds, 0);
        diamondsAmount += 1;
        PlayerPrefs.SetInt(diamonds, diamondsAmount  );
        PlayerPrefs.SetInt(key, 1);  
        diamonds = PlayerPrefs.GetInt(key, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

using TMPro;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    string diamondKey = "diamondKey";
    public TextMeshProUGUI diamondText;
    private int diamonds;
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
        diamonds = PlayerPrefs.GetInt(diamondKey, 0);
        diamonds += 1;
        PlayerPrefs.SetInt(diamondKey,diamonds);
        diamondText.text = diamonds.ToString();
        Debug.Log("Алмаз взят игроком");
        Destroy(gameObject);
        

    }
    
}

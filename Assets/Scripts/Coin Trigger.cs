using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class CoinTrigger : MonoBehaviour
{
    public string coinsKey = "collectedCoins";
    
   
    [FormerlySerializedAs("collector")] public CoinDisplayer displayer;
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
        
        
       
        displayer.CollectCoins();
        Destroy(gameObject);
        int coinsAmount = PlayerPrefs.GetInt(coinsKey, 0);
        coinsAmount += 1;
        PlayerPrefs.SetInt(coinsKey, coinsAmount);
        


    }
}

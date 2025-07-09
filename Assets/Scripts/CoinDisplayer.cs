using TMPro;
using UnityEngine;

public class CoinDisplayer : MonoBehaviour
{
    public string coinsKey = "collectedCoins";
    public TextMeshProUGUI coinText;
    private int Coins = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Coins = PlayerPrefs.GetInt(coinsKey, 0);
        coinText.text = Coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectCoins()
    {
        Coins++;
        coinText.text = Coins.ToString();
        
        
    }
}

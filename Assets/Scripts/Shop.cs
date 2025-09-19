using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Button buyButton;
    private int doubleJumpCost = 5;
    public string coinsKey = "collectedCoins";
    private int coins;
    public bool IsDoubleJumpSkillBought = false;
    public CoinDisplayer coinDisplayer;
    public TextMeshProUGUI coinText;

    private void OnEnable()
    {
        coins = PlayerPrefs.GetInt(coinsKey, 0);
        coinText.text = coins.ToString();    
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt(coinsKey, coins);
        coinDisplayer.UpdateCoinText();   
    }

    public void BuyDoubleJumpSkill()
    {
        if (coins >= doubleJumpCost)
        {
            IsDoubleJumpSkillBought = true;
            buyButton.interactable = false;
            coins -= doubleJumpCost;
            PlayerPrefs.SetInt(coinsKey, coins);
            coinDisplayer.UpdateCoinText();
            PlayerPrefs.SetInt("isDoubleJumpBought",1);
            coinText.text = coins.ToString();
            
        } 
    }
}


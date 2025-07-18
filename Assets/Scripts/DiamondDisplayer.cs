using TMPro;
using UnityEngine;

public class DiamondDisplayer : MonoBehaviour
{
    string diamondKey = "diamondKey";
    public TextMeshProUGUI diamondText;
    private int diamonds = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        diamonds = PlayerPrefs.GetInt(diamondKey, 0);
        diamondText.text = diamonds.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectDiamonds()
    {
        diamonds++;
        diamondText.text = diamonds.ToString();
        
        
    }
}

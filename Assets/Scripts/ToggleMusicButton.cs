using UnityEngine;
using UnityEngine.UI;

public class ToggleMusicButton : MonoBehaviour
{
    public Toggle toggle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toggle.isOn = BackGroundMusic.instance.isTurnedOn;
        toggle.onValueChanged.AddListener(OnToggleChanged);
    }

    private void OnToggleChanged(bool isOn)
    {
        BackGroundMusic.instance.TurnMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

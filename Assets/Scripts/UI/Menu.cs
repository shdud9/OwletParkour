using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private string LevelSave = "LevelSave";
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Play()
    {
        int LevelSaveInt = PlayerPrefs.GetInt(LevelSave, 1);
            SceneManager.LoadScene("LvL" + LevelSaveInt);
    }

    public void StartNewGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("LvL1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

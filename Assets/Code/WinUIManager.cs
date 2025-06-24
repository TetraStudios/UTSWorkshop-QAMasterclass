using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WinUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highscoreText;

    void Start()
    {
        bool newHighScore = false;
        
        if (Time.timeSinceLevelLoad < PlayerPrefs.GetFloat("winTime"))
        {
            newHighScore = true;
            PlayerPrefs.SetFloat("winTime", Time.timeSinceLevelLoad);
        }

        if (newHighScore)
        {
            highscoreText.text = "New high score!\nHigh Score: " + PlayerPrefs.GetFloat("winTime");
        }
        else
        {
            highscoreText.text = "Your Score: " + Time.timeSinceLevelLoad + "\nHigh Score: " + PlayerPrefs.GetFloat("winTime");
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI HighscoreText;

    

    // Start is called before the first frame update
    void Start()
    {
        HighscoreText.text = "Best Score : " + GameManager.Instance.names[0] + " : " + GameManager.Instance.points[0];
    }

    public void StartNew()
    {
        GameManager.Instance.currentName = playerName.text;
        
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // GameManager.Instance.SaveName();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    
}
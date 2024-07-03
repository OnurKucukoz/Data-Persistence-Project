using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public static MenuHandler menuHandler;
    public TMP_InputField inputNameField;
    public static string player_Name;

  /*  private void Awake()
    {
        if (menuHandler == null)
        {
            menuHandler = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }*/

    public void SetPlayerName()
    {
        player_Name = inputNameField.text;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!!!");
    }

    //public void NewHighestScore(int highestScore)
    //{

    //    MainManager.Instance.highestScore = highestScore;
    //}
}

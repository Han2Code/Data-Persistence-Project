using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{

    public Text oldScore;

    public void Start()
    {
        DataManager.Instance.LoadScore();
        oldScore.text = "High Score: " + DataManager.Instance.HighScoreName + " : " + DataManager.Instance.HighScoreValue;
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}

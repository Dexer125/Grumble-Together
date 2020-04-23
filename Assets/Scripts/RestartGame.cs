using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour {
    public GUIText score_one;
    public GUIText score_two;
    public int score1;
    public int score2;
    public GameObject finishsound;

    public void RestartLevel()
    {
        string sceneName = PlayerPrefs.GetString("lastLoadedScene");
     
        SceneManager.LoadScene(sceneName);
    }

    public void Awake()
    {
       int score1 = PlayerPrefs.GetInt("score1");
       int score2 = PlayerPrefs.GetInt("score2");

        score_one.text = ("Adam scored: " + score1.ToString());
        score_two.text = ("Timo scored: " + score2.ToString());
        finishsound.gameObject.SetActive(true);
        Cursor.visible = true;
    }

    public void MainMenu()
    {

     SceneManager.LoadScene(0);

    }
}



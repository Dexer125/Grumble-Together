using UnityEngine;
using System.Collections;

public class ScoreSolo : MonoBehaviour {
    public SimplePlatformController controll;
    public SimplePlatformController2 controll2;
    public GameObject player1;
    public GameObject player2;
    public GameObject camera1;
    public GameObject camera2;
    private int count11;
    private int count22;
    private int hiScoreCount;
    public GUIText lastHiscore;
    public int lastHighscore;
    public int playerChosen;
    

    public int choice;

    private int playerCoins;

     void Awake()
    {
        lastHighscore = PlayerPrefs.GetInt("HighScore");
        playerChosen = PlayerPrefs.GetInt("player");
       

        if (playerChosen == 1)
        {
            choice = playerChosen;
        }

        else if (playerChosen == 2)
        {
            choice = playerChosen;
        }

        if (choice == 1)
        {
            player1.gameObject.SetActive(true);
            player2.gameObject.SetActive(false);
            camera1.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
           


        }
        else if (choice == 2)
        {
            player1.gameObject.SetActive(false);
            player2.gameObject.SetActive(true);
            camera2.gameObject.SetActive(true);
            camera1.gameObject.SetActive(false);
           
        }
    }

    

    void FixedUpdate()
    {
        if (count11 > hiScoreCount )
        {
            hiScoreCount = count11;
        PlayerPrefs.SetInt("HighScore", hiScoreCount);
        PlayerPrefs.Save();
        Debug.Log("just saved this score: " + PlayerPrefs.GetInt("HighScore"));
      
        lastHiscore.text = "Last high score: " + lastHighscore.ToString();
    }

        else if (count22 > hiScoreCount)

            hiScoreCount = count22;
        PlayerPrefs.SetInt("HighScore", hiScoreCount);
        PlayerPrefs.Save();
        Debug.Log("just saved this score: " + PlayerPrefs.GetInt("HighScore"));

        lastHiscore.text = "Last high score: " + lastHighscore.ToString();
    }
    private void Update()
    {
        count11 = controll.count1;
        count22 = controll2.count2;
    }
}


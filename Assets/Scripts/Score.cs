using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public SimplePlatformController controll;
    public SimplePlatformController2 controll2;
    public int count11;
    public int count22;
    public GameObject player;

    public void Start()
    {
       // Cursor.visible = true;
    }

    public void Update()
    {
          count11 = controll.count1;
          count22 = controll2.count2;

        PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("score1", count11);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("score2", count22);
        PlayerPrefs.Save();

    }

  

    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Player1"))
        {
            other.gameObject.SetActive(false);
            GameOver();
           
        }

       else if (other.gameObject.CompareTag("Player2"))
        {
            other.gameObject.SetActive(false);
            GameOver();

        }

       
    }

  public  void GameOver()
    {
        
        if (count11 > count22)
        {
            SceneManager.LoadScene(4);
        }
        else if (count22 > count11)
        {
            SceneManager.LoadScene(3);
        }
        else if (count22 == count11)
        {
            SceneManager.LoadScene(8);
        }

    }


}
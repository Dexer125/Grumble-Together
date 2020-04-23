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
    public Text WinText;



    void Update()
    {
        if (controll != null)
            count11 = controll.count1;
        if (controll2 != null)
            count22 = controll2.count2;
    }

  

    public void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Player1"))
        {
            other.gameObject.SetActive(false);
            GameOver();
        }
    }

  public  void GameOver()
    {

        if (count11 > count22)
        {
            SceneManager.LoadScene(3);
        }
        else if (count22 > count11)
        {
            SceneManager.LoadScene(4);
        }

    }


}
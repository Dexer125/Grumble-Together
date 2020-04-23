using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterChoose : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;
    public Button player1button;
    public Button player2button;
   

   
    void Start () {
        player1.gameObject.SetActive(false);
        player2.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Player1_on()
    {
        player1.gameObject.SetActive(true);
    }

    public void Player1_off()
    {
        player1.gameObject.SetActive(false);
    }

    public void Player2_on()
    {
        player2.gameObject.SetActive(true);
    }

    public void Player2_off()
    {
        player2.gameObject.SetActive(false);
    }

    public void Player1_button()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("player", 1);
        PlayerPrefs.Save();
    }

    public void Player2_button()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("player", 2);
        PlayerPrefs.Save();
    }

    public void Back()
    {

        SceneManager.LoadScene(0);

        
    }
}
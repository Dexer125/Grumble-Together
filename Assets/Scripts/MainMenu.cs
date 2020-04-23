using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject robot0;
    public GameObject robot1;
    public GameObject robot2;
    public GameObject robot3;
    public GameObject sure;
    public GameObject def;
	
	void Awake () {
        robot0.gameObject.SetActive(true);
        robot1.gameObject.SetActive(false);
        robot2.gameObject.SetActive(false);
        robot3.gameObject.SetActive(false);
        sure.gameObject.SetActive(false);
        def.gameObject.SetActive(true);
        
    }

    public void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            Debug.Log("quit");

            sure.gameObject.SetActive(true);
            def.gameObject.SetActive(false);
        }
    }

    public void Robot_one()
    {

        robot1.gameObject.SetActive(true);
        robot0.gameObject.SetActive(false);

    }

    public void Robot_one_exit()
    {

        robot1.gameObject.SetActive(false);
        robot0.gameObject.SetActive(true);

    }

    public void Robot_two()
    {

        robot2.gameObject.SetActive(true);
        robot0.gameObject.SetActive(false);

    }

    public void Robot_two_exit()
    {

        robot2.gameObject.SetActive(false);
        robot0.gameObject.SetActive(true);
    }

    public void Robot_three()
    {

        robot3.gameObject.SetActive(true);
        robot0.gameObject.SetActive(false);
    }

    public void Robot_three_exit()
    {

        robot3.gameObject.SetActive(false);
        robot0.gameObject.SetActive(true);

    }

    public void StartGame()
    {

      SceneManager.LoadScene(9);
    }

    public void Multiplayer()
    {
        SceneManager.LoadScene(5);
    }

    public void Quit()
    {
        sure.gameObject.SetActive(true);
        def.gameObject.SetActive(false);
        
    }

    public void FirstLev()
    {

        SceneManager.LoadScene(2);
    }

    public void SecondLev()
    {

        SceneManager.LoadScene(6);
    }

    public void ThirdLev()
    {

        SceneManager.LoadScene(7);
    }

    public void Back()
    {

        SceneManager.LoadScene(0);

       
    }

    public void Yes()
    {

        Application.Quit();
        Debug.Log("yes");
    }

    public void No()
    {

        sure.gameObject.SetActive(false);
        def.gameObject.SetActive(true);
    }

}

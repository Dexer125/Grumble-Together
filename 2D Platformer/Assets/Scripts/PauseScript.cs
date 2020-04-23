using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour {
    GameObject PauseMenu;
    bool paused;
    bool muted;
    [SerializeField]
    Text mutetext;
	// Use this for initialization
	void Start () {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");

	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused; 
        }

        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }

        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;


        }

        if (muted)
        {

            AudioListener.volume = 0;
            mutetext.text = "Unmute";
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Mute";
            
        }
    }

    public void Resume()
    {
        paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Save()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        PlayerPrefs.SetInt("currentscenesave", currentScene.buildIndex);
    }
     
    public void Load()
    {

        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscenesave"));
    }

    public void Mute()
    {

        muted = !muted;

    }

    public void Quit()
    {
        Application.Quit();
       
    }


}


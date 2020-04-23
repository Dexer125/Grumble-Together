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
    public GameObject sure;
    public GameObject def;

    void Start () {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
        sure.gameObject.SetActive(false);
        def.gameObject.SetActive(true);

    }
	
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            Cursor.visible = true; 
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
            Cursor.visible = false;

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


    public void Mute()
    {

        muted = !muted;

    }

    public void Quit()
    {
        
        sure.gameObject.SetActive(true);
        def.gameObject.SetActive(false);

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

